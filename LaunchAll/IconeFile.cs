using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

namespace LaunchAll
{
    /// <summary>
    /// Recupera dalla shell di Windows l'icona che File Explorer mostra per un file
    /// (icona del programma associato all'estensione, o icona propria per exe/lnk/ico).
    /// </summary>
    internal static class IconeFile
    {
        private const uint SHGFI_ICON = 0x100;
        private const uint SHGFI_SMALLICON = 0x1;
        private const uint SHGFI_USEFILEATTRIBUTES = 0x10;
        private const uint FILE_ATTRIBUTE_NORMAL = 0x80;

        private static readonly string[] EstensioniConIconaPropria =
            { "", ".exe", ".lnk", ".ico", ".scr", ".cur", ".url", ".appref-ms" };

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct SHFILEINFO
        {
            public nint hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        }

        [DllImport("shell32.dll", CharSet = CharSet.Unicode)]
        private static extern nint SHGetFileInfo(string path, uint fileAttributes,
            ref SHFILEINFO info, uint infoSize, uint flags);

        [DllImport("user32.dll")]
        private static extern bool DestroyIcon(nint hIcon);

        /// <summary>
        /// Chiave per la cache delle icone: l'estensione se l'icona è comune a tutti
        /// i file di quel tipo, altrimenti il percorso completo.
        /// </summary>
        public static string Chiave(string percorso)
        {
            string estensione = Path.GetExtension(percorso).ToLowerInvariant();
            return System.Array.IndexOf(EstensioniConIconaPropria, estensione) >= 0
                ? percorso.ToLowerInvariant()
                : estensione;
        }

        /// <summary>Restituisce l'icona piccola del file, o null se la shell non ne fornisce una.</summary>
        public static Icon? Ottieni(string percorso)
        {
            uint flags = SHGFI_ICON | SHGFI_SMALLICON;
            // se il file non esiste (disco non collegato) si usa l'icona generica del tipo
            if (!File.Exists(percorso))
                flags |= SHGFI_USEFILEATTRIBUTES;

            SHFILEINFO info = new SHFILEINFO();
            nint risultato = SHGetFileInfo(percorso, FILE_ATTRIBUTE_NORMAL, ref info,
                (uint)Marshal.SizeOf<SHFILEINFO>(), flags);
            if (risultato == 0 || info.hIcon == 0)
                return null;

            try
            {
                using Icon temporanea = Icon.FromHandle(info.hIcon);
                return (Icon)temporanea.Clone();
            }
            finally
            {
                DestroyIcon(info.hIcon);
            }
        }
    }
}
