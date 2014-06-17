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
{   //TODO dare la possibilità di editare il contenuto della txtEdit 
    public partial class frmLaunchAll : Form
    {
        private string fileConfigurazioneIniziale = ""; 

        private ToolTip tt1 = new ToolTip();
        private ToolTip tt2 = new ToolTip();
        private ToolTip tt3 = new ToolTip();
        private ToolTip tt4 = new ToolTip();

        private Button[] btnConfigura = new Button[4];
        private Button[] btnCheckAll = new Button[4];

        private TextBox[] txtCartelle = new TextBox[4];
        private TextBox[] txtDischi = new TextBox[4];
        private ListView[] lstvw = new ListView[4];
        
        private int nListBox = 4; // numero delle listbox cartelle in interfacci utente

        public frmLaunchAll()
        {
            InitializeComponent();
        }

        public frmLaunchAll(string FileConfigurazione)
        {
            InitializeComponent();
            fileConfigurazioneIniziale = FileConfigurazione.Replace(".mall", ".lall");
        }

        private void frmLaunchAll_Load(object sender, EventArgs e)
        {
            btnConfigura[0] = btnConfigura1;
            btnConfigura[1] = btnConfigura2;
            btnConfigura[2] = btnConfigura3;
            btnConfigura[3] = btnConfigura4;

            btnCheckAll[0] = btnCheckAll1;
            btnCheckAll[1] = btnCheckAll2;
            btnCheckAll[2] = btnCheckAll3;
            btnCheckAll[3] = btnCheckAll4;

            txtCartelle[0] = txtCartella1;
            txtCartelle[1] = txtCartella2;
            txtCartelle[2] = txtCartella3;
            txtCartelle[3] = txtCartella4;

            txtDischi[0] = txtDisco1;
            txtDischi[1] = txtDisco2;
            txtDischi[2] = txtDisco3;
            txtDischi[3] = txtDisco4;
            
            lstvw[0] = lstvw1;
            lstvw[1] = lstvw2;
            lstvw[2] = lstvw3;
            lstvw[3] = lstvw4;

            txtFileConfigurazione.Text = fileConfigurazioneIniziale;

            if (txtFileConfigurazione.Text != "")
            {
                txtCartella1.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
                txtCartella2.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
                txtCartella3.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
                txtCartella4.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
            }

            ForzaAbilitazioneBottoni(LeggiFile(txtFileConfigurazione.Text, true));

            gamon.frmAbout f = new gamon.frmAbout();
            f.Visible = false;
            f.ShowDialog();
        }

        private void btnImporta_Click(object sender, EventArgs e)
        {
            opfilConfigurazione.Title = "Scelta file da importare";
            // scelta del file da importare
            opfilConfigurazione.Filter = "File di LaunchAll|*.lall";
            opfilConfigurazione.InitialDirectory = Path.GetDirectoryName(
                                        txtFileConfigurazione.Text);
            opfilConfigurazione.Multiselect = false;
            DialogResult r = opfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                LeggiFile(opfilConfigurazione.FileName, false); 
            }
        }

        private void btnEsporta_Click(object sender, EventArgs e)
        {
            svfilConfigurazione.Filter = "File di LaunchAll|*.lall";
            svfilConfigurazione.FileName = txtFileConfigurazione.Text;
            DialogResult r = svfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                //if (txtFileConfigurazione.Text == svfilConfigurazione.FileName)
                //{
                //    MessageBox.Show("Salva con nome non permesso con lo stesso nome");
                //    return; 
                //}
                txtFileConfigurazione.Text = svfilConfigurazione.FileName;
                SalvaFile();
                LeggiFileConfigurazione();
            }
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SalvaFile();
        }

        private bool LeggiFile(string PathENome, bool CancellaPrecedenti)
        {
            StreamReader sr;

            if (PathENome == "") return false; 

            try
            {
                // apertura del file 
                FileStream fsIn = new FileStream(PathENome,
                                    FileMode.Open, FileAccess.Read, FileShare.Read);
                sr = new StreamReader(fsIn);
            }
            catch
            {
                return false;
            }
            string Line;
            string[] campi; 
            Line = sr.ReadLine(); // lettura della prima riga (Cartella1)
            int riga = 0, nCartella = 0;
            while (Line != null && Line.Contains("Cartella") && nCartella < nListBox)
            //for (int nCartella = 0; nCartella < nListBox; nCartella++)
            {
                if (CancellaPrecedenti)
                    lstvw[nCartella].Items.Clear();
                //txtCartelle[nCartella].Text = sr.ReadLine(); // directory di default
                
                // directory di default
                separaDiscoEPath(sr.ReadLine(), nCartella);

                riga = 0;
                Line = sr.ReadLine();
                while (Line !=null && Line.Contains("|"))
                {
                    campi = Line.Split('|');
                    lstvw[nCartella].Items.Add(campi[0]);
                    if (campi[1] != "NAB")
                        lstvw[nCartella].Items[riga].Checked = true;
                    else
                        lstvw[nCartella].Items[riga].Checked = false;
                    riga++;
                    Line = sr.ReadLine();
                }
                    nCartella++;
            }
            sr.Close();
            return true; 
        }

        private bool SalvaFile()
        {
            // taglia un eventuale \ in fondo
            //TODO fare un metodo e lanciarlo anche prima di ogni parte che include la composizione di cartella e nome del file 
            foreach (TextBox t in txtCartelle)
            {
                if (t.Text != "" && t.Text.LastIndexOf('\\') == t.Text.Length - 1)
                    t.Text = t.Text.Substring(0, t.Text.Length - 1);
            }
            // apertura file di uscita 
            StreamWriter fileOut = openFileOut(txtFileConfigurazione.Text, false);
            if (fileOut != null)
            {
                // salvataggio dei file che fanno riferimento alle nListBox cartelle in UI
                int i;
                for (int nCartella = 0; nCartella < nListBox; nCartella++)
                {
                    fileOut.WriteLine("Cartella" + nCartella);
                    fileOut.WriteLine(discoEFile(nCartella));
                    for (i = 0; i < lstvw[nCartella].Items.Count; i++)
                    {
                        fileOut.Write(lstvw[nCartella].Items[i].Text.Replace(
                                        discoEFile(nCartella), "."));
                        if (lstvw[nCartella].Items[i].Checked)
                            fileOut.WriteLine("|AB");
                        else
                            fileOut.WriteLine("|NAB");
                    }
                }
            }
                //    // taglia eventuali \ nelle cartelle delle directory
                //    if (txtCartellaCopia.Text != "" &&
                //        txtCartellaCopia.Text.LastIndexOf('\\') == 
                //        txtCartellaCopia.Text.Length - 1)
                //        txtCartellaCopia.Text = 
                //            txtCartellaCopia.Text.Substring(0, 
                //            txtCartellaCopia.Text.Length - 1);
                //    if (txtRootDir.Text != "" &&
                //            txtRootDir.Text.LastIndexOf('\\') ==
                //            txtRootDir.Text.Length - 1)
                //        txtRootDir.Text =
                //            txtRootDir.Text.Substring(0,
                //            txtRootDir.Text.Length - 1);

                //    fileOut.WriteLine("CartellaRootPerCreazione");
                //    fileOut.WriteLine(txtRootDir.Text);
                //    fileOut.WriteLine("CartellaDefaultPerCopia");
                //    fileOut.WriteLine(txtCartellaCopia.Text);
                //    fileOut.WriteLine("FilesDaCopiare"); 
                //    for (i = 0; i < lstvwFileDaCopiare.Items.Count; i++)
                //    {
                //        fileOut.Write(lstvwFileDaCopiare.Items[i].Text.Replace(
                //                        txtCartellaCopia.Text, "."));
                //        if (lstvwFileDaCopiare.Items[i].Checked)
                //            fileOut.Write("|AB");
                //        else
                //            fileOut.Write("|NAB");
                //        // aggiunge la cartella di destinazione
                //        // se c'è qualcosa nella seconda colonna copia nel file la seconda colonna
                //        // se non c'è niente nella seconda colonna, mette nel file l'indicazione di root
                //        if (lstvwFileDaCopiare.Items[i].SubItems.Count >1 && lstvwFileDaCopiare.Items[i].SubItems[1].Text != "")
                //            fileOut.WriteLine("|" + lstvwFileDaCopiare.Items[i].SubItems[1].Text);
                //        else
                //            fileOut.WriteLine("|.\\");
                //    }
                //    // copia dell'albero delle cartelle da creare, dal form nascosto 
                //    fileOut.WriteLine("AlberoCartelleDaCreare");
                //    foreach (TreeNode nodoRadice in trwCartelleDaCreare.Nodes)
                //    // chiamata ricorsiva a SalvaFiglio
                //    {
                //        SalvaFiglio(nodoRadice, fileOut);
                //        // salva la path completa del nodo solo se esso non ha figli
                //        if (nodoRadice.Nodes == null)
                //            fileOut.WriteLine(nodoRadice.FullPath);
                //    }
                //    fileOut.Close();
                //}
            else // file non apribile 
            {
                MessageBox.Show("File non creabile"); 
                fileOut.Close();
                return false;
            }

            fileOut.Close();
            LeggiFile(txtFileConfigurazione.Text,true);
            return true; 
        }

        private void btnConfigura_Click(object sender, EventArgs e)
        {
            //Button cliccato = (Button)sender; 
            //int nCartella = Convert.ToInt32(cliccato.Name.Substring(12,1));
            //frmConfiguraFiles f = new frmConfiguraFiles(txtFileConfigurazione.Text, 
            //                       txtCartelle[nCartella-1].Text, nCartella ,lstvw[nCartella-1]);
            //f.ShowDialog();
        }

        private void txtFileConfigurazione_TextChanged(object sender, EventArgs e)
        {
            string pathDefault="";

            ForzaAbilitazioneBottoni(File.Exists(txtFileConfigurazione.Text));
            this.Text = Path.GetFileName(txtFileConfigurazione.Text) + " | " + this.Text.Substring (this.Text.IndexOf("|")+1).Trim(); ;
            //if (txtFileConfigurazione.Text != "") 
            //    pathDefault = Path.GetDirectoryName(txtFileConfigurazione.Text);
            //if (pathDefault != "")
            //    txtCartella1.Text = pathDefault;
        }

        private void txtCartella_TextChanged(object sender, EventArgs e)
        {
            tt1.SetToolTip(txtCartella1, txtCartella1.Text);
            tt1.Active = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tt2.SetToolTip(txtCartella2, txtCartella2.Text);
            tt2.Active = true;
        }

        private void txt3Certificati_TextChanged(object sender, EventArgs e)
        {
            tt3.SetToolTip(txtCartella3, txtCartella3.Text);
            tt3.Active = true;
        }

        private void btnApriFileConfigurazione_Click(object sender, EventArgs e)
        {
            opfilConfigurazione.Title = "Scelta file da aprire";
            opfilConfigurazione.Filter = "File di LaunchAll|*.lall";
            try
            {
                opfilConfigurazione.InitialDirectory = Path.GetDirectoryName(
                                                txtFileConfigurazione.Text);
            }
            catch (Exception er) { }
            opfilConfigurazione.FileName = "*.lall"; 
            opfilConfigurazione.Multiselect = false;
            DialogResult r = opfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtFileConfigurazione.Text = opfilConfigurazione.FileName;
                LeggiFileConfigurazione();
            }
        }

        private void txtCartella_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox cliccato = (TextBox)sender;
            int nCartella = Convert.ToInt32(cliccato.Name.Substring(11, 1));
            txtEdit.Text = discoEFile(nCartella-1);
        }

        private string discoEFile(int cartella)
        {
            return txtDischi[cartella].Text + txtCartelle[cartella].Text;
        }

        private void separaDiscoEPath(string fileCompleto, int nCartella)
        {
            try
            {
                // disco
                txtDischi[nCartella].Text = Path.GetPathRoot(fileCompleto);
                // path senza disco 
                txtCartelle[nCartella].Text = fileCompleto.Replace(txtDischi[nCartella].Text, "");
            }
            catch { }
        }

        private void btnTrovaESostituisci_Click(object sender, EventArgs e)
        {
            frmSostituzione f = new frmSostituzione(txtFileConfigurazione.Text);
            f.ShowDialog();
            LeggiFile(txtFileConfigurazione.Text, true);
        }

        private void btnCreaCartelle_Click(object sender, EventArgs e)
        {
            try
            {
                // chiama l'altro programma con una shell passandogli due parametri 
                // passa FileConfigurazione, PathInizio 
                string stringaArgomenti = txtFileConfigurazione.Text + " "
                    + txtCartella4.Text
                    ;
                System.Diagnostics.Process.Start(".\\MakeAllDirs.exe ", stringaArgomenti);
            }
            catch (Exception ur)
            {
                MessageBox.Show("Il programma MakeAllDirs non è eseguibile");
            }
        }

        private void btnApriTutti_Click(object sender, EventArgs e)
        {
            int i = 0;
            for (int cartella = 0; cartella < nListBox; cartella++)
            {
                for (i = 0; i < lstvw[cartella].Items.Count; i++)
                {
                    string nomeFile = lstvw[cartella].Items[i].Text.Replace(".\\",
                                                            discoEFile(cartella) + "\\");
                    if (lstvw[cartella].Items[i].Checked)
                        try
                        {
                            System.Diagnostics.Process.Start(nomeFile);
                        }
                        catch (Exception er)
                        {
                            MessageBox.Show("Errore nell'aprire il file " + nomeFile);
                            //+ "\nErrore: " + er.ToString());
                        }
                }
            }
        }

        private void btnCartella_Click(object sender, EventArgs e)
        {
            Button cliccato = (Button)sender;
            int nCartella = Convert.ToInt32(cliccato.Name.Substring(11, 1));
            folderBrowserDialog.SelectedPath=discoEFile(nCartella-1);
            DialogResult r = folderBrowserDialog.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                separaDiscoEPath(folderBrowserDialog.SelectedPath, nCartella - 1);
            }
        }

        private void btnApriFile_Click(object sender, EventArgs e)
        {
            LeggiFileConfigurazione();
        }

        private void LeggiFileConfigurazione()
        {
            if (File.Exists(txtFileConfigurazione.Text))
            {
                LeggiFile(txtFileConfigurazione.Text, true);
                ForzaAbilitazioneBottoni(true);
                foreach (ListView l in lstvw)
                    l.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            else
            {
                MessageBox.Show("Il file non esiste");
            }
        }

        private void ForzaAbilitazioneBottoni(bool Stato)
        {
            btnTrovaESostituisci.Enabled = Stato;
            btnEsporta.Enabled = Stato;
            btnImporta.Enabled = Stato;
            btnSalva.Enabled = Stato;
            btnApriTutti.Enabled = Stato;
            btnApriFile.Enabled = Stato;
            btnCreaCartelle.Enabled = Stato;
            //foreach (Button b in btnConfigura)
            //{
            //    b.Enabled = stato;
            //}
            btnPiu1.Enabled = Stato;
            btnPiu2.Enabled = Stato;
            btnPiu3.Enabled = Stato;
            btnPiu4.Enabled = Stato;
            btnMeno1.Enabled = Stato;
            btnMeno2.Enabled = Stato;
            btnMeno3.Enabled = Stato;
            btnMeno4.Enabled = Stato;
            btnApri1.Enabled = Stato;
            btnApri2.Enabled = Stato;
            btnApri3.Enabled = Stato;
            btnApri4.Enabled = Stato;
            btnDeCheckAll1.Enabled = Stato;
            btnDeCheckAll2.Enabled = Stato;
            btnDeCheckAll3.Enabled = Stato;
            btnDeCheckAll4.Enabled = Stato;
            btnCheckAll1.Enabled = Stato;
            btnCheckAll2.Enabled = Stato;
            btnCheckAll3.Enabled = Stato;
            btnCheckAll4.Enabled = Stato;
        }
        
        private static StreamWriter openFileOut(string NomeFile, bool appendi)
        {
            Encoding fileEncoding = Encoding.Default;
            try
            {
                //prova ad aprire il file
                FileStream fsOut;
                if (appendi)
                    fsOut = new FileStream(NomeFile, FileMode.Append, FileAccess.Write, FileShare.Read);
                else
                    fsOut = new FileStream(NomeFile, FileMode.Create, FileAccess.Write, FileShare.Read);
                StreamWriter fOut = new StreamWriter(fsOut, fileEncoding);
                return (fOut);
            }
            catch (Exception e)
            {	// il nome del file è sbagliato o non si riesce ad aprirlo
                //Console.WriteLine("Non si riesce ad aprire il file. Provo a crearlo" + NomeFile + "\r\nErrore:" + e.Message);
                Console.WriteLine("Non si riesce ad aprire il file. Provo a crearlo" + NomeFile);
                // lo apro creandolo
                FileStream fsOut = new FileStream(NomeFile, FileMode.Create, FileAccess.Write, FileShare.Read);
                StreamWriter fOut = new StreamWriter(fsOut, fileEncoding);

                return (fOut);
            }
        }

        private void btnPiu_Click(object sender, EventArgs e)
        {
            Button bottone = (Button)sender;
            int nCartella = Convert.ToInt32(bottone.Name.Substring(6, 1));

            opfilScelta.InitialDirectory = discoEFile(nCartella - 1);
            opfilScelta.Multiselect = true;
            DialogResult r = opfilScelta.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                foreach (string file in opfilScelta.FileNames)
                {
                    lstvw[nCartella - 1].Items.Add(file);
                    // lo segna
                    lstvw[nCartella - 1].Items[lstvw[nCartella - 1].Items.Count-1].Checked = true;
                }
            }
            lstvw[nCartella - 1].AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnMeno_Click(object sender, EventArgs e)
        {
            Button bottone = (Button)sender;
            int nCartella = Convert.ToInt32(bottone.Name.Substring(7, 1));

            // rimozione multipla
            foreach (ListViewItem item in lstvw[nCartella - 1].SelectedItems)
                lstvw[nCartella - 1].Items.Remove(item);
        }

        private void btnApriCartella_Click(object sender, EventArgs e)
        {
            Button bottone = (Button)sender;
            int nCartella = Convert.ToInt32(bottone.Name.Substring(7, 1));

            int i = 0;
            for (i = 0; i < lstvw[nCartella - 1].Items.Count; i++)
            {
                string nomeFile = lstvw[nCartella - 1].Items[i].Text.Replace(".\\", discoEFile(nCartella-1) + "\\"); 
                if (lstvw[nCartella - 1].Items[i].Checked)
                    try
                    {
                        System.Diagnostics.Process.Start(nomeFile);
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show("Errore nell'aprire il file " + nomeFile);
                        //+ "\nErrore: " + er.ToString());
                    }
            }
        }

        private void lstvw_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lista = (ListView)sender;
            int nCartella = Convert.ToInt32(lista.Name.Substring(5, 1));

            try
            {
                txtEdit.Text = lista.SelectedItems[0].Text;
            }
            catch
            {
                //Beep(); 
            }
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            svfilConfigurazione.Filter = "File di ApriTutto|*.lall";
            DialogResult r = svfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtFileConfigurazione.Text = svfilConfigurazione.FileName;
                txtCartella1.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
                //txtCartella2.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
                //txtCartella3.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
                //txtCartella4.Text = Path.GetDirectoryName(txtFileConfigurazione.Text);
                foreach (ListView lista in lstvw)
                    lista.Items.Clear();
                SalvaFile();
                LeggiFileConfigurazione();
            }
        }

        private void btnConfigura4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("da fare");
        }

        private void txtCartella_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TextBox bottone = (TextBox)sender;
            int nCartella = Convert.ToInt32(bottone.Name.Substring(11, 1));
            try
            {
                System.Diagnostics.Process.Start(discoEFile(nCartella-1));
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire la cartella " + txtEdit.Text);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void lstvw_DoubleClick(object sender, EventArgs e)
        {
            ListView lista = (ListView)sender;
            int nCartella = Convert.ToInt32(lista.Name.Substring(5, 1));
            string nomeFile = lista.SelectedItems[0].Text.Replace(".\\",
                                                discoEFile(nCartella - 1) + "\\");
            try
            {
                System.Diagnostics.Process.Start(nomeFile);
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire il file " + nomeFile);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void txtEdit_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(txtEdit.Text);
            }
            catch (Exception er)
            {
                MessageBox.Show("Errore nell'aprire " + txtEdit.Text);
                //+ "\nErrore: " + er.ToString());
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            Button bottone = (Button)sender;
            int nCartella = Convert.ToInt32(bottone.Name.Substring(11, 1));
            foreach (ListViewItem nodo in lstvw[nCartella-1].Items)
                nodo.Checked = true; 
        }

        private void btnDeCheckAll_Click(object sender, EventArgs e)
        {
            Button bottone = (Button)sender;
            int nCartella = Convert.ToInt32(bottone.Name.Substring(13, 1));
            foreach (ListViewItem nodo in lstvw[nCartella-1].Items)
                nodo.Checked = false; 
        }

        private void btnCambiaDisco_Click(object sender, EventArgs e)
        {
            if (txtDisco.Text != "")
            {
                foreach (TextBox tb in txtDischi)
                {
                    //if (tb.Text.IndexOf(':') == 1)
                    //{
                    //    char[] dummy = tb.Text.ToCharArray();
                    //    dummy[0] = (char)txtDisco.Text[0];
                    //    tb.Text = new string(dummy);
                    //}
                    tb.Text = txtDisco.Text + ":\\"; 
                }
            }
        }

        private void txtDisco_TextChanged(object sender, EventArgs e)
        {
            if (txtDisco.Text.Length > 1)
            {
                Console.Beep();
                txtDisco.Text= txtDisco.Text.Substring(1, 1);
            }
        }

        private void frmLaunchAll_Resize(object sender, EventArgs e)
        {
            foreach (ListView l in lstvw)
                if (l != null)
                    l.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void lstvw_Enter(object sender, EventArgs e)
        {
            ListView lista = (ListView)sender;
            int nCartella = Convert.ToInt32(lista.Name.Substring(5, 1));

            try
            {
                lista.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            catch
            {
                //Beep(); 
            }
        }

    }
}
