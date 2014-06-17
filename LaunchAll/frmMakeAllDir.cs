using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LaunchAll
{
    public partial class frmMakeAllDir : Form
    {
        string fileConfigurazione;

        public frmMakeAllDir(string PathInizio, string PathCopia, string FileConfigurazione)
        {
            InitializeComponent();
            txtRootDir.Text = PathInizio;
            txtCartellaCopia.Text = PathCopia;
            fileConfigurazione = FileConfigurazione;
        }

        public frmMakeAllDir()
        {
            InitializeComponent();
        }

        private void btnCartellaRoot_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtRootDir.Text;
            DialogResult r = folderBrowserDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtRootDir.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnCartellaCopia_Click(object sender, EventArgs e)
        {
            folderBrowserDialog.SelectedPath = txtCartellaCopia.Text;
            DialogResult r = folderBrowserDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtCartellaCopia.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnPiuAlbero_Click(object sender, EventArgs e)
        {
            string etichetta;
            if (txtNuova.Text != "")
                etichetta = txtNuova.Text;
            else
                etichetta="Nuova cartella";
            if (trwCartelleDaCreare.SelectedNode != null)
            {
                // figlio
                TreeNode temp = new TreeNode(etichetta);
                trwCartelleDaCreare.SelectedNode.Nodes.Add(temp);
                trwCartelleDaCreare.SelectedNode = temp;
                temp.Checked = true; 
                temp.BeginEdit();
            }
        }

        private void btnPiuCopia_Click(object sender, EventArgs e)
        {
            opfilScelta.InitialDirectory = txtCartellaCopia.Text;
            opfilScelta.Multiselect = true;
            opfilScelta.FileName = "";
            DialogResult r = opfilScelta.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in opfilScelta.FileNames)
                {
                    cklstFileDaCopiare.Items.Add(file);
                    // lo segna
                    cklstFileDaCopiare.Items[cklstFileDaCopiare.Items.Count - 1].Checked=true;
                }
            }
        }

        private void btnMenoCopia_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in cklstFileDaCopiare.SelectedItems)
                cklstFileDaCopiare.Items.Remove(item);
        }

        private void cklstFileDaCopiare_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                //TODO aggiustare!!!!!!
                //txtEdit.Text = cklstFileDaCopiare.SelectedItem.ToString();
            }
            catch
            {
                //Beep(); 
            }
        }

        private void btnCreaECopia_Click(object sender, EventArgs e)
        {
            btnCreaCartelle_Click(null, null);
            btnCopia_Click(null, null);
        }

        private void btnMenoAlbero_Click(object sender, EventArgs e)
        {
            if (trwCartelleDaCreare.SelectedNode !=null)
                trwCartelleDaCreare.SelectedNode.Remove();
        }

        private void btnCartellaPerCopiare_Click(object sender, EventArgs e)
        {
            try
            {
                cklstFileDaCopiare.SelectedItems[0].SubItems[1].Text = ".\\" + trwCartelleDaCreare.SelectedNode.FullPath;
            }
            catch
            {

            }
        }

        private void txtRootDir_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtRootDir.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire il file " + txtRootDir.Text);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void txtCartellaCopia_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtCartellaCopia.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire il file " + txtCartellaCopia.Text);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etichetta;
            if (txtNuova.Text != "")
                etichetta = txtNuova.Text;
            else
                etichetta = "Nuova cartella";
            // padre
            TreeNode temp = new TreeNode(etichetta);
            trwCartelleDaCreare.Nodes.Add(temp);
            temp.Checked = true; 
            temp.BeginEdit();
        }

        private void btnCreaCartelle_Click(object sender, EventArgs e)
        {
            foreach (TreeNode nodoRadice in trwCartelleDaCreare.Nodes)
            // chiamata ricorsiva a SalvaFiglio
            {
                CreaFiglio(nodoRadice);
                //if (nodoRadice.Checked)
                //    Directory.CreateDirectory(nodoRadice.FullPath);
            }
        }

        private void CreaFiglio(TreeNode NodoCorrente)
        {
            // visita tutti i figli che ha, ricorsivamente. Quando li ha finiti salva sè stesso e torna. 
            foreach (TreeNode figlio in NodoCorrente.Nodes)
            {
                CreaFiglio(figlio);
            }
            // crea la path completa del nodo solo se essp è checkato
            if (NodoCorrente.Checked)
                Directory.CreateDirectory(txtRootDir.Text +"\\"+ NodoCorrente.FullPath);
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem fileDaCopiare in cklstFileDaCopiare.Items)
            {
                if (fileDaCopiare.Checked)
                {
                    string filePartenza = (txtCartellaCopia.Text + "\\" + fileDaCopiare.Text).Replace(
                                            ".\\", "");
                    string fileDestinazione = (txtRootDir.Text + "\\" + fileDaCopiare.SubItems[1].Text +
                                               fileDaCopiare.Text.Remove(0, fileDaCopiare.Text.LastIndexOf("\\"))).Replace(".\\", "");
                    File.Copy(filePartenza, fileDestinazione);
                }
            }
        }

        private void btnPiuPiu_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.ExpandAll();
        }

        private void btnMenoMeno_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.CollapseAll();
        }
    }
}
