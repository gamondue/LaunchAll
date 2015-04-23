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
    public partial class frmMakeAllDirs : Form
    {
        private string fileConfigurazioneIniziale = "";

        string versione = "V." + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

        public frmMakeAllDirs()
        {
            InitializeComponent();
        }

        public frmMakeAllDirs(string FileConfigurazione)
        {
            InitializeComponent();
            fileConfigurazioneIniziale = FileConfigurazione;
        }

        public frmMakeAllDirs(string FileConfigurazione, string PathCopia)
        {
            InitializeComponent();
            txtRootDir.Text = FileConfigurazione.Substring(0,FileConfigurazione.LastIndexOf("\\"));
            txtCartellaCopia.Text = PathCopia;
            fileConfigurazioneIniziale = FileConfigurazione.Replace(".lall", ".mall");
        }

        private void frmMakeAllDirs_Load(object sender, EventArgs e)
        {
            this.Text += " " + versione;

            gamon.frmAbout f = new gamon.frmAbout();
            f.Visible = false;
            f.ShowDialog();
            txtFileConfigurazione.Text = fileConfigurazioneIniziale;
            ForzaAbilitazioneBottoni(LeggiFile(txtFileConfigurazione.Text, true));

            try
            {
                txtDiscoNuovo.Text = txtFileConfigurazione.Text.Substring(0, 1) + ":\\";
                txtDiscoVecchio.Text = txtRootDir.Text.Substring(0, 1) + ":\\";
            }
            catch { }

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
                    lstvwFileDaCopiare.Items.Add(file);
                    // lo segna
                    lstvwFileDaCopiare.Items[lstvwFileDaCopiare.Items.Count - 1].Checked=true;
                }
            }
            lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnMenoCopia_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstvwFileDaCopiare.SelectedItems)
                lstvwFileDaCopiare.Items.Remove(item);
        }

        private void btnCreaECopia_Click(object sender, EventArgs e)
        {
            btnCreaCartelle_Click(null, null);
            btnCopia_Click(null, null);
            MessageBox.Show("Fatto");
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
                foreach (ListViewItem riga in lstvwFileDaCopiare.SelectedItems)
                    riga.SubItems[1].Text = ".\\" + trwCartelleDaCreare.SelectedNode.FullPath;
                lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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
                MessageBox.Show("Errore nell'aprire la cartella " + txtRootDir.Text);
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
            MessageBox.Show("Fatto");
        }

        private void CreaFiglio(TreeNode NodoCorrente)
        {
            // visita tutti i figli che ha, ricorsivamente. Quando li ha finiti salva sè stesso e torna. 
            foreach (TreeNode figlio in NodoCorrente.Nodes)
            {
                CreaFiglio(figlio);
            }
            // crea la path completa del nodo solo se esso è checkato
            if (NodoCorrente.Checked)
                Directory.CreateDirectory(txtRootDir.Text +"\\"+ NodoCorrente.FullPath);
        }

        private void btnCopia_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem fileDaCopiare in lstvwFileDaCopiare.Items)
            {
                string filePartenza = ""; 
                string fileDestinazione=""; 
                try
                {
                    if (fileDaCopiare.Checked)
                    {
                        filePartenza = (txtCartellaCopia.Text + "\\" + fileDaCopiare.Text).Replace(
                                                ".\\", "");
                        string soloNomeFileDaCopiare;
                        if (txtStringaDa.Text != "")
                        {
                            soloNomeFileDaCopiare = Path.GetFileName(fileDaCopiare.SubItems[0].Text).Replace(
                                                txtStringaDa.Text, txtStringaA.Text);
                        }
                        else
                        {
                            soloNomeFileDaCopiare = Path.GetFileName(fileDaCopiare.SubItems[0].Text);
                        }
                        if (txtStringa2Da.Text != "")
                        {
                            soloNomeFileDaCopiare = Path.GetFileName(soloNomeFileDaCopiare).Replace(
                                                txtStringa2Da.Text, txtStringa2A.Text);
                        }
                        //string pathCartellaDestinazione = txtRootDir.Text + "\\" + fileDaCopiare.SubItems[1].Text.Replace(".\\", "");
                        string pathCartellaDestinazione = txtRootDir.Text +  "\\"+ fileDaCopiare.SubItems[1].Text.Replace(".\\", "");
                        fileDestinazione = (pathCartellaDestinazione + "\\" + soloNomeFileDaCopiare);
                        //fileDaCopiare.Text.Remove(0, fileDaCopiare.Text.LastIndexOf("\\"))).
                        //Replace(".\\", "").Replace(textBox2.Text, textBox1.Text); 
                        File.Copy(filePartenza, fileDestinazione);
                    }
                }
                catch (Exception ex)
                {
                    if (!File.Exists(fileDestinazione)) 
                        MessageBox.Show("Impossibile copiare il file " + fileDestinazione); 
                    else
                        if (MessageBox.Show("Il file " + fileDestinazione +" esiste già. Lo si vuole copiare comunque?",
                            "Errore", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) 
                            == DialogResult.Yes)
                            File.Copy(filePartenza, fileDestinazione,true);
                }
            }
            MessageBox.Show("Fatto");
        }

        private void btnPiuPiu_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.ExpandAll();
        }

        private void btnMenoMeno_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.CollapseAll();
        }

        private void trwCartelleDaCreare_AfterSelect(object sender, TreeViewEventArgs e)
        {
            txtEdit.Text = trwCartelleDaCreare.SelectedNode.Text;
        }

        private void btnLaunchAll_Click(object sender, EventArgs e)
        {
            try
            {
                // chiama l'altro programma con una shell passandogli un parametro
                // passa FileConfigurazione 
                string stringaArgomenti = txtFileConfigurazione.Text;
                System.Diagnostics.Process.Start(".\\LaunchAll.exe ", stringaArgomenti);
            }
            catch (Exception ur)
            {
                MessageBox.Show("Il programma LaunchAll non è eseguibile");
            }
        }
        
        private void TagliaBackSlash()
        {
            if (txtCartellaCopia.Text != "" &&
                txtCartellaCopia.Text.LastIndexOf('\\') == 
                txtCartellaCopia.Text.Length - 1)
                txtCartellaCopia.Text = 
                    txtCartellaCopia.Text.Substring(0, 
                    txtCartellaCopia.Text.Length - 1);
            if (txtRootDir.Text != "" &&
                    txtRootDir.Text.LastIndexOf('\\') ==
                    txtRootDir.Text.Length - 1)
                txtRootDir.Text =
                    txtRootDir.Text.Substring(0,
                    txtRootDir.Text.Length - 1);
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

        private bool SalvaFile()
        {
            // taglia un eventuale \ in fondo nelle box di directory
            //TODO fare un metodo e lanciarlo anche prima di ogni parte che include la composizione di cartella e nome del file 

            // taglia eventuali \ nelle cartelle delle directory
            TagliaBackSlash();
            // apertura file di uscita 
            StreamWriter fileOut = openFileOut(txtFileConfigurazione.Text, false);

            if (fileOut != null)
            {
                fileOut.WriteLine("CartellaRootPerCreazione");
                fileOut.WriteLine(txtRootDir.Text);
                fileOut.WriteLine("CartellaDefaultPerCopia");
                fileOut.WriteLine(txtCartellaCopia.Text);
                fileOut.WriteLine("FilesDaCopiare"); 
                for (int i = 0; i < lstvwFileDaCopiare.Items.Count; i++)
                {
                    fileOut.Write(lstvwFileDaCopiare.Items[i].Text.Replace(
                                    txtCartellaCopia.Text, "."));
                    if (lstvwFileDaCopiare.Items[i].Checked)
                        fileOut.Write("|AB");
                    else
                        fileOut.Write("|NAB");
                    // aggiunge la cartella di destinazione
                    // se c'è qualcosa nella seconda colonna copia nel file la seconda colonna
                    // se non c'è niente nella seconda colonna, mette nel file l'indicazione di root
                    if (lstvwFileDaCopiare.Items[i].SubItems.Count >1 && lstvwFileDaCopiare.Items[i].SubItems[1].Text != "")
                        fileOut.WriteLine("|" + lstvwFileDaCopiare.Items[i].SubItems[1].Text);
                    else
                        fileOut.WriteLine("|.\\");
                }
                // copia dell'albero delle cartelle da creare, dal form nascosto 
                fileOut.WriteLine("AlberoCartelleDaCreare");
                foreach (TreeNode nodoRadice in trwCartelleDaCreare.Nodes)
                // chiamata ricorsiva a SalvaFiglio
                {
                    SalvaFiglio(nodoRadice, fileOut);
                    // salva la path completa del nodo solo se esso non ha figli
                    if (nodoRadice.Nodes == null)
                        fileOut.WriteLine(nodoRadice.FullPath);
                }
            }
            else // file non apribile 
            {
                MessageBox.Show("File non creabile"); 
            }
            //TODO rimettere la lettura
            // LeggiFile(txtFileConfigurazione.Text,true);
            fileOut.Close();
            return true;
    }

        private void SalvaFiglio(TreeNode NodoCorrente, StreamWriter fileOut)
        {
            // visita tutti i figli che ha, ricorsivamente. Quando li ha finiti salva sè stesso e torna. 
            foreach (TreeNode figlio in NodoCorrente.Nodes)
            {
                SalvaFiglio(figlio, fileOut);
            }
            // salva la path completa del nodo solo se esso non ha figli
            if (NodoCorrente.Nodes.Count == 0)
            {
                if (NodoCorrente.Checked)
                    fileOut.WriteLine(NodoCorrente.FullPath + "|AB");
                else
                    fileOut.WriteLine(NodoCorrente.FullPath + "|NAB");
            }
        }

        private bool LeggiFile(string PathENome, bool CancellaPrecedenti)
        {
            StreamReader sr;
            int riga = 0;
            string Line;
            string[] campi; 

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

            // butta via la prima riga
            sr.ReadLine();
            // ora nella linea c'è CartellaRootPerCreazione

            // legge la prima cartella
            txtRootDir.Text = sr.ReadLine();
            //????
            //if (txtRootDir.Text == "")
            //    txtRootDir.Text = txtCartella1.Text;

            // butta via la scritta CartellaDefaultPerCopia
            Line = sr.ReadLine();
            txtCartellaCopia.Text = sr.ReadLine();
            if (CancellaPrecedenti)
                lstvwFileDaCopiare.Items.Clear();

            //????
            //if (txtCartellaCopia.Text == "")
            //    txtCartellaCopia.Text = txtCartella2.Text;

            // butta via la scritta FilesDaCopiare
            Line = sr.ReadLine();

            lstvwFileDaCopiare.View = View.Details;
            riga = 0;
            while ((Line = sr.ReadLine()) != "AlberoCartelleDaCreare")
            {
                if (Line != "")
                {
                    campi = Line.Split('|');
                    ListViewItem item1 = new ListViewItem(campi[0], riga);
                    // mette in seconda colonna le directory di destinazione
                    item1.SubItems.Add(campi[2]);
                    lstvwFileDaCopiare.Items.AddRange(new ListViewItem[] { item1 });
                    if (campi[1] != "NAB")
                        lstvwFileDaCopiare.Items[riga].Checked = true;
                    else
                        lstvwFileDaCopiare.Items[riga].Checked = false;
                    riga++;
                }
            }
            // riempimento dell'albero

            TreeView albero = trwCartelleDaCreare;
            // lettura della struttura di cartelle da creare
            if (CancellaPrecedenti)
                foreach (TreeNode nodo in trwCartelleDaCreare.Nodes)
                    trwCartelleDaCreare.Nodes.Remove(nodo);
            
            string fullPath;
            while ((fullPath = sr.ReadLine()) != null)
            {
                if (fullPath != "") {
                bool pathAbilitata = (fullPath.Substring(fullPath.LastIndexOf("|")) == "|AB");
                fullPath = fullPath.Remove(fullPath.LastIndexOf("|")); 
                TreeNode nodoRadice = null; 
                ElaboraNodo(nodoRadice, fullPath, pathAbilitata);
                }
            }
            trwCartelleDaCreare.ExpandAll();
            // chiusura dello StreamReader
            sr.Close();
            return true;
        }

        private void ElaboraNodo(TreeNode NodoCorrente, string Path, bool Abilitata)
        {
            string cartellaFiglia;
            int slash = Path.IndexOf("\\");
            if (slash >= 0)
                cartellaFiglia = Path.Substring(0,slash);
            else
                cartellaFiglia = Path;

            TreeNode figlio = null; // nodo figlio nell'albero
            bool trovato;
            if (NodoCorrente == null)
            {   // è un nodo iniziale
                trovato = false;
                foreach (TreeNode temp in trwCartelleDaCreare.Nodes)
                {
                    if (cartellaFiglia == temp.Text)
                    {
                        trovato = true;
                        figlio = temp;
                        break;
                    }
                }
                if (!trovato)
                {
                    figlio = new TreeNode(cartellaFiglia);
                    trwCartelleDaCreare.Nodes.Add(figlio);
                }
            }
            else
            {
                // cerca fra i figli del nodo corrente cerca se c'è la cartella che è stata passata
                trovato = false;
                if (NodoCorrente.Nodes != null)
                {
                    foreach (TreeNode temp in NodoCorrente.Nodes)
                    {
                        if (cartellaFiglia == temp.Text)
                        {
                            trovato = true;
                            figlio = temp;
                            break;
                        }
                    }
                }
                else
                {
                    // è un nodo 

                }
                // se la trova, non fa niente perchè c'è gia
                if (!trovato)
                {
                    // se non c'è crea un nodo e lo mette come figlio corrente
                    figlio = new TreeNode(cartellaFiglia);
                    NodoCorrente.Nodes.Add(figlio);
                }
            }
            if (Abilitata) // se lo segna una volta non lo cancella più
                figlio.Checked = Abilitata;
            // se la path passata ha nuovi figli, taglia il nodo appena elaborato e passa al prossimo
            if (slash >= 0)
            {
                string nuovaPath = Path.Substring(slash+1);
                ElaboraNodo(figlio, nuovaPath, Abilitata);
            }
        }

        private void btnApriFileConfigurazione_Click(object sender, EventArgs e)
        {
            opfilConfigurazione.Title = "Scelta file da aprire";
            opfilConfigurazione.Filter = "File di ApriTutto|*.mall";
            try
            {
                opfilConfigurazione.InitialDirectory = Path.GetDirectoryName(
                                                txtFileConfigurazione.Text);
            }
            catch { }
            opfilConfigurazione.FileName = "*.mall";
            opfilConfigurazione.Multiselect = false;
            DialogResult r = opfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtFileConfigurazione.Text = opfilConfigurazione.FileName;
                LeggiFileConfigurazione();
            }
        }

        private void LeggiFileConfigurazione()
        {
            if (File.Exists(txtFileConfigurazione.Text))
            {
                LeggiFile(txtFileConfigurazione.Text, true);
                ForzaAbilitazioneBottoni(true);
                lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
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
            btnApriFile.Enabled = Stato;
            btnCreaCartelle.Enabled = Stato;
            //foreach (Button b in btnConfigura)
            //{
            //    b.Enabled = stato;
            //}
            btnPiuCopia.Enabled = Stato;
            btnMenoCopia.Enabled = Stato;
            btnCopia.Enabled = Stato;
            btnCartellaPerCopiare.Enabled = Stato;
            btnPiuInizio.Enabled = Stato;
            btnPiuAlbero.Enabled = Stato;
            btnMenoAlbero.Enabled = Stato;
            btnPiuPiu.Enabled = Stato;
            btnMenoMeno.Enabled = Stato;
            btnCreaCartelle.Enabled = Stato;
            btnDeCheckAll.Enabled = Stato;
            btnCheckAll.Enabled = Stato;
            btnDisabilitaCreare.Enabled = Stato;
            btnAbilitaCreare.Enabled = Stato;
            btnCheckOff.Enabled = Stato;
            btnCheckOn.Enabled = Stato;
            btnOrdina.Enabled = Stato;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            SalvaFile();
            LeggiFileConfigurazione();
        }

        private void btnApriFile_Click(object sender, EventArgs e)
        {
            LeggiFileConfigurazione();
        }

        private void btnNuovo_Click(object sender, EventArgs e)
        {
            svfilConfigurazione.Filter = "File di MakeAllDirs|*.mall";
            DialogResult r = svfilConfigurazione.ShowDialog();
            if (r == System.Windows.Forms.DialogResult.OK)
            {
                txtFileConfigurazione.Text = svfilConfigurazione.FileName;
                lstvwFileDaCopiare.Items.Clear();
                SalvaFile();
                LeggiFileConfigurazione();
            }
        }

        private void btnImporta_Click(object sender, EventArgs e)
        {
            opfilConfigurazione.Title = "Scelta file da importare";
            // scelta del file da importare
            opfilConfigurazione.Filter = "File di MakeAllDirs|*.mall";
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
            svfilConfigurazione.Filter = "File di MakeAllDirs|*.mall";
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

        private void txtFileConfigurazione_TextChanged(object sender, EventArgs e)
        {
            string pathDefault = "";

            ForzaAbilitazioneBottoni(File.Exists(txtFileConfigurazione.Text));
            this.Text = Path.GetFileName(txtFileConfigurazione.Text) + " | " + this.Text.Substring(this.Text.IndexOf("|") + 1).Trim(); ;
            //if (txtFileConfigurazione.Text != "")
            //    pathDefault = Path.GetDirectoryName(txtFileConfigurazione.Text);
        }

        private void lstvwFileDaCopiare_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtEdit.Text = lstvwFileDaCopiare.SelectedItems[0].Text;
            }
            catch
            {
                //Console.Beep();
            }
        }

        //private void lstvwFileDaCopiare_SelectedIndexChanged_1(object sender, EventArgs e)
        //{
        //    ListView lista = (ListView)sender;

        //    try
        //    {
        //        txtEdit.Text = lista.SelectedItems[0].Text;
        //    }
        //    catch
        //    {
        //        //Beep(); 
        //    }
        //}

        private void btnTrovaESostituisci_Click(object sender, EventArgs e)
        {
            frmSostituzione f = new frmSostituzione(txtFileConfigurazione.Text);
            f.ShowDialog();
            LeggiFile(txtFileConfigurazione.Text, true);
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

        private void trwCartelleDaCreare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                trwCartelleDaCreare.SelectedNode.BeginEdit();
        }

        private void lstvwFileDaCopiare_DoubleClick(object sender, EventArgs e)
        {
            ListView lista = (ListView)sender;
            string nomeFile = lista.SelectedItems[0].Text.Replace(".\\",
                                                txtCartellaCopia.Text + "\\");
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

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem nodo in lstvwFileDaCopiare.Items)
                nodo.Checked = true; 
        }

        private void btnDeCheckAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem nodo in lstvwFileDaCopiare.Items)
                nodo.Checked = false; 
        }

        private void btnAbilitaCreare_Click(object sender, EventArgs e)
        {
            foreach (TreeNode nodo in trwCartelleDaCreare.Nodes)
            {
                AbilitaAlbero(nodo, true);
                nodo.Checked = true;
            }
        }

        private void btnDisabilitaCreare_Click(object sender, EventArgs e)
        {
            foreach (TreeNode nodo in trwCartelleDaCreare.Nodes)
            {
                AbilitaAlbero(nodo, false);
                nodo.Checked = false;
            }
        }

        private void AbilitaAlbero(TreeNode Nodo, bool Abilita) {
            foreach (TreeNode n in Nodo.Nodes)
            {
                AbilitaAlbero(n, false);
                n.Checked = Abilita;
            }
        }

        private void btnCheckOff_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstvwFileDaCopiare.Items)
                i.Checked = false;

        }

        private void btnCheckOn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in lstvwFileDaCopiare.Items)
                i.Checked = true;
        }

        private void txtDisco_TextChanged(object sender, EventArgs e)
        {
            if (txtDiscoNuovo.Text.Length > 1)
            {
                Console.Beep();
                txtDiscoNuovo.Text = txtDiscoNuovo.Text.Substring(1, 1);
            }
        }

        private void btnCambiaDisco_Click(object sender, EventArgs e)
        {
            // se manca la slash alla fine del nome del disco, la aggiunge
            if (txtDiscoVecchio.Text.Substring(txtDiscoVecchio.Text.Length - 1, 1) != "\\")
                txtDiscoVecchio.Text += "\\";
            if (txtDiscoNuovo.Text.Substring(txtDiscoNuovo.Text.Length - 1, 1) != "\\")
                txtDiscoNuovo.Text += "\\";

            if (txtRootDir.Text != "" && txtDiscoNuovo.Text != "")
            {
                txtRootDir.Text = txtRootDir.Text.Replace(txtDiscoVecchio.Text, txtDiscoNuovo.Text);
                txtCartellaCopia.Text = txtCartellaCopia.Text.Replace(txtDiscoVecchio.Text, txtDiscoNuovo.Text);
            }
            // sostituzione letterale all'interno delle listview
            foreach (ListViewItem it in lstvwFileDaCopiare.Items)
            {
                it.Text = it.Text.Replace(txtDiscoVecchio.Text + ":\\", txtDiscoNuovo.Text + ":\\");
            }
        }

        private void btnCreaCartella_Click(object sender, EventArgs e)
        {
            try
            {
                System.IO.Directory.CreateDirectory(txtRootDir.Text);
            }
            catch
            {
                Console.Beep(); ;
            }
        }

        private void lstvwFileDaCopiare_Enter(object sender, EventArgs e)
        {
            lstvwFileDaCopiare.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void txtDiscoVecchio_MouseClick(object sender, MouseEventArgs e)
        {
            txtEdit.Text = txtDiscoVecchio.Text;
        }

        private void txtDiscoNuovo_MouseClick(object sender, MouseEventArgs e)
        {
            txtEdit.Text = txtDiscoNuovo.Text;
        }

        private void txtDiscoVecchio_Leave(object sender, EventArgs e)
        {
            if (txtDiscoVecchio.Text != "")
                if (txtDiscoVecchio.Text.Substring(txtDiscoVecchio.Text.Length - 1, 1) != "\\")
                txtDiscoVecchio.Text += "\\";
        }

        private void txtDiscoNuovo_Leave(object sender, EventArgs e)
        {
            if (txtDiscoNuovo.Text != "")
                if (txtDiscoNuovo.Text.Substring(txtDiscoNuovo.Text.Length - 1, 1) != "\\")
                txtDiscoNuovo.Text += "\\";
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            trwCartelleDaCreare.Sort();
        }
    }
}
