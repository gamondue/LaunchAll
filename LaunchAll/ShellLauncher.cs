using System.Diagnostics;

namespace LaunchAll
{
    /// <summary>
    /// Apre file, cartelle o eseguibili tramite la shell di Windows.
    /// In .NET (Core/5+) Process.Start(string) ha UseShellExecute = false,
    /// quindi i file con programma associato all'estensione non partirebbero.
    /// </summary>
    internal static class ShellLauncher
    {
        public static void Apri(string percorso)
        {
            Process.Start(new ProcessStartInfo(percorso) { UseShellExecute = true });
        }
    }
}
