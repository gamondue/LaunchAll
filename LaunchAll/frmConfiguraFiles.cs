using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LaunchAll
{
    public partial class frmConfiguraFiles : Form
    {
        private string nomeFile;
        private string pathStart;
        private int nCartella;
        private string p;
        private string p_2;
        private CheckedListBox checkedListCartella;

        public frmConfiguraFiles()
        {
            InitializeComponent();
        }

        public frmConfiguraFiles(string NomeFileConfigurazione, string StartPath, int NCartella, CheckedListBox CheckedListCartella)
        {
            InitializeComponent();
            nCartella = NCartella;
            nomeFile = NomeFileConfigurazione;
            pathStart = StartPath;
            this.Text = "Cart. " + nCartella + ": configurazione";
            checkedListCartella = CheckedListCartella;
        }

        private void frmApriFiles_Load(object sender, EventArgs e)
        {
            CaricaLista();
        }

        private void btnPiu_Click(object sender, EventArgs e)
        {
            opfilScelta.InitialDirectory = pathStart;
            opfilScelta.Multiselect = true;
            DialogResult r = opfilScelta.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in opfilScelta.FileNames)
                    lstFiles.Items.Add(file);
            }
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            //TODO rimozione multipla
            //foreach (object oggetto in lstFiles.SelectedItems)
            //    lstFiles.Items.Remove(oggetto);
            lstFiles.Items.Remove(lstFiles.SelectedItem);
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < lstFiles.Items.Count; i++)
            {
                if (lstFiles.GetItemCheckState(i) == CheckState.Checked)
                    try
                    {
                        System.Diagnostics.Process.Start(lstFiles.Items[i].ToString().Replace(".\\", pathStart + "\\"));
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Errore nell'aprire il file " + lstFiles.Items[i].ToString());
                                        //+ "\nErrore: " + er.ToString());
                    }
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            //string[,] files = new string[lstFiles.Items.Count, 2];
            //int i = 0;
            //for (i = 0; i < lstFiles.Items.Count; i++)
            //{
            //    files[i, 0] = lstFiles.Items[i].ToString().Replace(pathStart, ".");
            //    if (lstFiles.GetItemCheckState(i) == CheckState.Checked)
            //        files[i, 1] = "abil";
            //    else
            //        files[i, 1] = "disab";
            //}
            //gamon.FileDiTesto.MatriceInFile(nomeFile, files, '|', false);
            //CaricaLista();
        }

        private void CaricaLista()
        {
            lstFiles.Items.Clear();
            int i=0;
            foreach (object item in checkedListCartella.Items)
            {
                lstFiles.Items.Add(item);
                // copia check status:
                //lstFiles.Items[i];
                i++;
            }
        }

        private void lstFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CheckedListBox lista = (CheckedListBox)sender; 
            try
            {
                System.Diagnostics.Process.Start(lista.SelectedItem.ToString().Replace(".\\", pathStart + "\\"));
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire il file " + sender.ToString()); 
                                //+ "\nErrore: " + er.ToString());
            }
        }
    }
}
