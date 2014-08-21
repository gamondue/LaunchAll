namespace LaunchAll
{
    partial class frmMakeAllDirs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeAllDirs));
            this.label2 = new System.Windows.Forms.Label();
            this.txtRootDir = new System.Windows.Forms.TextBox();
            this.btnCreaECopia = new System.Windows.Forms.Button();
            this.txtCartellaCopia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMenoCopia = new System.Windows.Forms.Button();
            this.btnPiuCopia = new System.Windows.Forms.Button();
            this.btnCreaCartelle = new System.Windows.Forms.Button();
            this.btnMenoAlbero = new System.Windows.Forms.Button();
            this.btnPiuAlbero = new System.Windows.Forms.Button();
            this.btnCartellaRoot = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btnCartellaCopia = new System.Windows.Forms.Button();
            this.opfilScelta = new System.Windows.Forms.OpenFileDialog();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnPiuInizio = new System.Windows.Forms.Button();
            this.btnCopia = new System.Windows.Forms.Button();
            this.btnMenoMeno = new System.Windows.Forms.Button();
            this.btnPiuPiu = new System.Windows.Forms.Button();
            this.btnLaunchAll = new System.Windows.Forms.Button();
            this.btnNuovo = new System.Windows.Forms.Button();
            this.btnApriFile = new System.Windows.Forms.Button();
            this.btnTrovaESostituisci = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApriFileConfigurazione = new System.Windows.Forms.Button();
            this.btnEsporta = new System.Windows.Forms.Button();
            this.btnImporta = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFileConfigurazione = new System.Windows.Forms.TextBox();
            this.svfilConfigurazione = new System.Windows.Forms.SaveFileDialog();
            this.opfilConfigurazione = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtStringa2Da = new System.Windows.Forms.TextBox();
            this.txtStringa2A = new System.Windows.Forms.TextBox();
            this.btnCheckOff = new System.Windows.Forms.Button();
            this.btnCheckOn = new System.Windows.Forms.Button();
            this.btnDeCheckAll = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStringaDa = new System.Windows.Forms.TextBox();
            this.txtStringaA = new System.Windows.Forms.TextBox();
            this.lstvwFileDaCopiare = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCartellaPerCopiare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDisabilitaCreare = new System.Windows.Forms.Button();
            this.btnAbilitaCreare = new System.Windows.Forms.Button();
            this.txtNuova = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trwCartelleDaCreare = new System.Windows.Forms.TreeView();
            this.btnCreaCartella = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscoVecchio = new System.Windows.Forms.TextBox();
            this.btnCambiaDisco = new System.Windows.Forms.Button();
            this.txtDiscoNuovo = new System.Windows.Forms.TextBox();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cartella di partenza in cui creare cartelle e file";
            // 
            // txtRootDir
            // 
            this.txtRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootDir.Location = new System.Drawing.Point(6, 86);
            this.txtRootDir.Name = "txtRootDir";
            this.txtRootDir.Size = new System.Drawing.Size(939, 20);
            this.txtRootDir.TabIndex = 3;
            this.txtRootDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtRootDir_MouseDoubleClick);
            // 
            // btnCreaECopia
            // 
            this.btnCreaECopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreaECopia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreaECopia.ForeColor = System.Drawing.Color.White;
            this.btnCreaECopia.Location = new System.Drawing.Point(867, 9);
            this.btnCreaECopia.Name = "btnCreaECopia";
            this.btnCreaECopia.Size = new System.Drawing.Size(78, 28);
            this.btnCreaECopia.TabIndex = 5;
            this.btnCreaECopia.Text = "Crea e copia";
            this.btnCreaECopia.UseVisualStyleBackColor = false;
            this.btnCreaECopia.Click += new System.EventHandler(this.btnCreaECopia_Click);
            // 
            // txtCartellaCopia
            // 
            this.txtCartellaCopia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCartellaCopia.Location = new System.Drawing.Point(6, 130);
            this.txtCartellaCopia.Name = "txtCartellaCopia";
            this.txtCartellaCopia.Size = new System.Drawing.Size(939, 20);
            this.txtCartellaCopia.TabIndex = 8;
            this.txtCartellaCopia.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCartellaCopia_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cartella da cui copiare file";
            // 
            // btnMenoCopia
            // 
            this.btnMenoCopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenoCopia.Location = new System.Drawing.Point(30, 245);
            this.btnMenoCopia.Name = "btnMenoCopia";
            this.btnMenoCopia.Size = new System.Drawing.Size(26, 21);
            this.btnMenoCopia.TabIndex = 45;
            this.btnMenoCopia.Text = "-";
            this.btnMenoCopia.UseVisualStyleBackColor = true;
            this.btnMenoCopia.Click += new System.EventHandler(this.btnMenoCopia_Click);
            // 
            // btnPiuCopia
            // 
            this.btnPiuCopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPiuCopia.Location = new System.Drawing.Point(0, 245);
            this.btnPiuCopia.Name = "btnPiuCopia";
            this.btnPiuCopia.Size = new System.Drawing.Size(24, 21);
            this.btnPiuCopia.TabIndex = 44;
            this.btnPiuCopia.Text = "+";
            this.btnPiuCopia.UseVisualStyleBackColor = true;
            this.btnPiuCopia.Click += new System.EventHandler(this.btnPiuCopia_Click);
            // 
            // btnCreaCartelle
            // 
            this.btnCreaCartelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreaCartelle.Location = new System.Drawing.Point(325, 245);
            this.btnCreaCartelle.Name = "btnCreaCartelle";
            this.btnCreaCartelle.Size = new System.Drawing.Size(75, 21);
            this.btnCreaCartelle.TabIndex = 49;
            this.btnCreaCartelle.Text = "Crea cartelle";
            this.btnCreaCartelle.UseVisualStyleBackColor = true;
            this.btnCreaCartelle.Click += new System.EventHandler(this.btnCreaCartelle_Click);
            // 
            // btnMenoAlbero
            // 
            this.btnMenoAlbero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenoAlbero.Location = new System.Drawing.Point(86, 245);
            this.btnMenoAlbero.Name = "btnMenoAlbero";
            this.btnMenoAlbero.Size = new System.Drawing.Size(26, 21);
            this.btnMenoAlbero.TabIndex = 48;
            this.btnMenoAlbero.Text = "-";
            this.btnMenoAlbero.UseVisualStyleBackColor = true;
            this.btnMenoAlbero.Click += new System.EventHandler(this.btnMenoAlbero_Click);
            // 
            // btnPiuAlbero
            // 
            this.btnPiuAlbero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPiuAlbero.Location = new System.Drawing.Point(56, 245);
            this.btnPiuAlbero.Name = "btnPiuAlbero";
            this.btnPiuAlbero.Size = new System.Drawing.Size(24, 21);
            this.btnPiuAlbero.TabIndex = 47;
            this.btnPiuAlbero.Text = "+";
            this.btnPiuAlbero.UseVisualStyleBackColor = true;
            this.btnPiuAlbero.Click += new System.EventHandler(this.btnPiuAlbero_Click);
            // 
            // btnCartellaRoot
            // 
            this.btnCartellaRoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartellaRoot.Location = new System.Drawing.Point(910, 61);
            this.btnCartellaRoot.Name = "btnCartellaRoot";
            this.btnCartellaRoot.Size = new System.Drawing.Size(36, 22);
            this.btnCartellaRoot.TabIndex = 50;
            this.btnCartellaRoot.Text = "..";
            this.btnCartellaRoot.UseVisualStyleBackColor = true;
            this.btnCartellaRoot.Click += new System.EventHandler(this.btnCartellaRoot_Click);
            // 
            // btnCartellaCopia
            // 
            this.btnCartellaCopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartellaCopia.Location = new System.Drawing.Point(910, 106);
            this.btnCartellaCopia.Name = "btnCartellaCopia";
            this.btnCartellaCopia.Size = new System.Drawing.Size(36, 22);
            this.btnCartellaCopia.TabIndex = 51;
            this.btnCartellaCopia.Text = "..";
            this.btnCartellaCopia.UseVisualStyleBackColor = true;
            this.btnCartellaCopia.Click += new System.EventHandler(this.btnCartellaCopia_Click);
            // 
            // opfilScelta
            // 
            this.opfilScelta.FileName = "da_creare.mall";
            // 
            // txtEdit
            // 
            this.txtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdit.Location = new System.Drawing.Point(301, 159);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.ReadOnly = true;
            this.txtEdit.Size = new System.Drawing.Size(644, 20);
            this.txtEdit.TabIndex = 52;
            this.txtEdit.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtEdit_MouseDoubleClick);
            // 
            // btnPiuInizio
            // 
            this.btnPiuInizio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPiuInizio.Location = new System.Drawing.Point(1, 245);
            this.btnPiuInizio.Name = "btnPiuInizio";
            this.btnPiuInizio.Size = new System.Drawing.Size(49, 21);
            this.btnPiuInizio.TabIndex = 60;
            this.btnPiuInizio.Text = "+ inizio";
            this.btnPiuInizio.UseVisualStyleBackColor = true;
            this.btnPiuInizio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopia
            // 
            this.btnCopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopia.Location = new System.Drawing.Point(449, 245);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(85, 21);
            this.btnCopia.TabIndex = 63;
            this.btnCopia.Text = "Copia files";
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // btnMenoMeno
            // 
            this.btnMenoMeno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenoMeno.Location = new System.Drawing.Point(164, 245);
            this.btnMenoMeno.Name = "btnMenoMeno";
            this.btnMenoMeno.Size = new System.Drawing.Size(32, 21);
            this.btnMenoMeno.TabIndex = 63;
            this.btnMenoMeno.Text = "--";
            this.btnMenoMeno.UseVisualStyleBackColor = true;
            this.btnMenoMeno.Click += new System.EventHandler(this.btnMenoMeno_Click);
            // 
            // btnPiuPiu
            // 
            this.btnPiuPiu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPiuPiu.Location = new System.Drawing.Point(126, 245);
            this.btnPiuPiu.Name = "btnPiuPiu";
            this.btnPiuPiu.Size = new System.Drawing.Size(32, 21);
            this.btnPiuPiu.TabIndex = 62;
            this.btnPiuPiu.Text = "++";
            this.btnPiuPiu.UseVisualStyleBackColor = true;
            this.btnPiuPiu.Click += new System.EventHandler(this.btnPiuPiu_Click);
            // 
            // btnLaunchAll
            // 
            this.btnLaunchAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLaunchAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLaunchAll.ForeColor = System.Drawing.Color.White;
            this.btnLaunchAll.Location = new System.Drawing.Point(787, 9);
            this.btnLaunchAll.Name = "btnLaunchAll";
            this.btnLaunchAll.Size = new System.Drawing.Size(78, 28);
            this.btnLaunchAll.TabIndex = 64;
            this.btnLaunchAll.Text = "LaunchAll";
            this.btnLaunchAll.UseVisualStyleBackColor = false;
            this.btnLaunchAll.Visible = false;
            this.btnLaunchAll.Click += new System.EventHandler(this.btnLaunchAll_Click);
            // 
            // btnNuovo
            // 
            this.btnNuovo.Location = new System.Drawing.Point(436, 9);
            this.btnNuovo.Name = "btnNuovo";
            this.btnNuovo.Size = new System.Drawing.Size(78, 28);
            this.btnNuovo.TabIndex = 71;
            this.btnNuovo.Text = "Nuovo";
            this.btnNuovo.UseVisualStyleBackColor = true;
            this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
            // 
            // btnApriFile
            // 
            this.btnApriFile.Location = new System.Drawing.Point(519, 9);
            this.btnApriFile.Name = "btnApriFile";
            this.btnApriFile.Size = new System.Drawing.Size(78, 28);
            this.btnApriFile.TabIndex = 70;
            this.btnApriFile.Text = "Apri";
            this.btnApriFile.UseVisualStyleBackColor = true;
            this.btnApriFile.Click += new System.EventHandler(this.btnApriFile_Click);
            // 
            // btnTrovaESostituisci
            // 
            this.btnTrovaESostituisci.Enabled = false;
            this.btnTrovaESostituisci.Location = new System.Drawing.Point(133, 9);
            this.btnTrovaESostituisci.Name = "btnTrovaESostituisci";
            this.btnTrovaESostituisci.Size = new System.Drawing.Size(105, 28);
            this.btnTrovaESostituisci.TabIndex = 69;
            this.btnTrovaESostituisci.Text = "Trova e sostituisci";
            this.btnTrovaESostituisci.UseVisualStyleBackColor = true;
            this.btnTrovaESostituisci.Click += new System.EventHandler(this.btnTrovaESostituisci_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Location = new System.Drawing.Point(602, 9);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(78, 28);
            this.btnSalva.TabIndex = 68;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApriFileConfigurazione
            // 
            this.btnApriFileConfigurazione.Location = new System.Drawing.Point(685, 9);
            this.btnApriFileConfigurazione.Name = "btnApriFileConfigurazione";
            this.btnApriFileConfigurazione.Size = new System.Drawing.Size(78, 28);
            this.btnApriFileConfigurazione.TabIndex = 67;
            this.btnApriFileConfigurazione.Text = "Scegli file";
            this.btnApriFileConfigurazione.UseVisualStyleBackColor = true;
            this.btnApriFileConfigurazione.Click += new System.EventHandler(this.btnApriFileConfigurazione_Click);
            // 
            // btnEsporta
            // 
            this.btnEsporta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEsporta.Location = new System.Drawing.Point(243, 9);
            this.btnEsporta.Name = "btnEsporta";
            this.btnEsporta.Size = new System.Drawing.Size(105, 28);
            this.btnEsporta.TabIndex = 66;
            this.btnEsporta.Text = "Salva con nome";
            this.btnEsporta.UseVisualStyleBackColor = true;
            this.btnEsporta.Click += new System.EventHandler(this.btnEsporta_Click);
            // 
            // btnImporta
            // 
            this.btnImporta.Location = new System.Drawing.Point(353, 9);
            this.btnImporta.Name = "btnImporta";
            this.btnImporta.Size = new System.Drawing.Size(78, 28);
            this.btnImporta.TabIndex = 65;
            this.btnImporta.Text = "Importa";
            this.btnImporta.UseVisualStyleBackColor = true;
            this.btnImporta.Click += new System.EventHandler(this.btnImporta_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "File di configurazione";
            // 
            // txtFileConfigurazione
            // 
            this.txtFileConfigurazione.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileConfigurazione.Location = new System.Drawing.Point(6, 40);
            this.txtFileConfigurazione.Name = "txtFileConfigurazione";
            this.txtFileConfigurazione.Size = new System.Drawing.Size(939, 20);
            this.txtFileConfigurazione.TabIndex = 72;
            this.txtFileConfigurazione.TextChanged += new System.EventHandler(this.txtFileConfigurazione_TextChanged);
            // 
            // svfilConfigurazione
            // 
            this.svfilConfigurazione.FileName = "da_creare.mall";
            // 
            // opfilConfigurazione
            // 
            this.opfilConfigurazione.FileName = "da_creare.mall";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(6, 186);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtStringa2Da);
            this.splitContainer1.Panel1.Controls.Add(this.txtStringa2A);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckOff);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckOn);
            this.splitContainer1.Panel1.Controls.Add(this.btnCopia);
            this.splitContainer1.Panel1.Controls.Add(this.btnDeCheckAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnCheckAll);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txtStringaDa);
            this.splitContainer1.Panel1.Controls.Add(this.txtStringaA);
            this.splitContainer1.Panel1.Controls.Add(this.lstvwFileDaCopiare);
            this.splitContainer1.Panel1.Controls.Add(this.btnCartellaPerCopiare);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.btnPiuCopia);
            this.splitContainer1.Panel1.Controls.Add(this.btnMenoCopia);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnCreaCartelle);
            this.splitContainer1.Panel2.Controls.Add(this.btnDisabilitaCreare);
            this.splitContainer1.Panel2.Controls.Add(this.btnAbilitaCreare);
            this.splitContainer1.Panel2.Controls.Add(this.txtNuova);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.trwCartelleDaCreare);
            this.splitContainer1.Panel2.Controls.Add(this.btnPiuInizio);
            this.splitContainer1.Panel2.Controls.Add(this.btnPiuAlbero);
            this.splitContainer1.Panel2.Controls.Add(this.btnMenoAlbero);
            this.splitContainer1.Panel2.Controls.Add(this.btnPiuPiu);
            this.splitContainer1.Panel2.Controls.Add(this.btnMenoMeno);
            this.splitContainer1.Size = new System.Drawing.Size(947, 281);
            this.splitContainer1.SplitterDistance = 535;
            this.splitContainer1.TabIndex = 74;
            // 
            // txtStringa2Da
            // 
            this.txtStringa2Da.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStringa2Da.Location = new System.Drawing.Point(0, 219);
            this.txtStringa2Da.Name = "txtStringa2Da";
            this.txtStringa2Da.Size = new System.Drawing.Size(286, 20);
            this.txtStringa2Da.TabIndex = 68;
            this.txtStringa2Da.Text = "YYYY";
            // 
            // txtStringa2A
            // 
            this.txtStringa2A.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStringa2A.Location = new System.Drawing.Point(292, 219);
            this.txtStringa2A.Name = "txtStringa2A";
            this.txtStringa2A.Size = new System.Drawing.Size(243, 20);
            this.txtStringa2A.TabIndex = 69;
            // 
            // btnCheckOff
            // 
            this.btnCheckOff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckOff.Location = new System.Drawing.Point(62, 245);
            this.btnCheckOff.Name = "btnCheckOff";
            this.btnCheckOff.Size = new System.Drawing.Size(32, 21);
            this.btnCheckOff.TabIndex = 66;
            this.btnCheckOff.Text = "off";
            this.btnCheckOff.UseVisualStyleBackColor = true;
            this.btnCheckOff.Click += new System.EventHandler(this.btnCheckOff_Click);
            // 
            // btnCheckOn
            // 
            this.btnCheckOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCheckOn.Location = new System.Drawing.Point(100, 245);
            this.btnCheckOn.Name = "btnCheckOn";
            this.btnCheckOn.Size = new System.Drawing.Size(32, 21);
            this.btnCheckOn.TabIndex = 67;
            this.btnCheckOn.Text = "on";
            this.btnCheckOn.UseVisualStyleBackColor = true;
            this.btnCheckOn.Click += new System.EventHandler(this.btnCheckOn_Click);
            // 
            // btnDeCheckAll
            // 
            this.btnDeCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeCheckAll.Location = new System.Drawing.Point(234, 245);
            this.btnDeCheckAll.Name = "btnDeCheckAll";
            this.btnDeCheckAll.Size = new System.Drawing.Size(59, 21);
            this.btnDeCheckAll.TabIndex = 65;
            this.btnDeCheckAll.Text = "Disabilita";
            this.btnDeCheckAll.UseVisualStyleBackColor = true;
            this.btnDeCheckAll.Click += new System.EventHandler(this.btnDeCheckAll_Click);
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckAll.Location = new System.Drawing.Point(297, 245);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(59, 21);
            this.btnCheckAll.TabIndex = 64;
            this.btnCheckAll.Text = "Abilita";
            this.btnCheckAll.UseVisualStyleBackColor = true;
            this.btnCheckAll.Click += new System.EventHandler(this.btnCheckAll_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(292, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Stringa A: ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Sostituzione durante la copia: stringa Da: ";
            // 
            // txtStringaDa
            // 
            this.txtStringaDa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtStringaDa.Location = new System.Drawing.Point(0, 196);
            this.txtStringaDa.Name = "txtStringaDa";
            this.txtStringaDa.Size = new System.Drawing.Size(286, 20);
            this.txtStringaDa.TabIndex = 61;
            this.txtStringaDa.Text = "XXXX";
            // 
            // txtStringaA
            // 
            this.txtStringaA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStringaA.Location = new System.Drawing.Point(292, 196);
            this.txtStringaA.Name = "txtStringaA";
            this.txtStringaA.Size = new System.Drawing.Size(243, 20);
            this.txtStringaA.TabIndex = 62;
            // 
            // lstvwFileDaCopiare
            // 
            this.lstvwFileDaCopiare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstvwFileDaCopiare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.lstvwFileDaCopiare.CheckBoxes = true;
            this.lstvwFileDaCopiare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstvwFileDaCopiare.Location = new System.Drawing.Point(0, 16);
            this.lstvwFileDaCopiare.Name = "lstvwFileDaCopiare";
            this.lstvwFileDaCopiare.Size = new System.Drawing.Size(535, 160);
            this.lstvwFileDaCopiare.TabIndex = 56;
            this.lstvwFileDaCopiare.UseCompatibleStateImageBehavior = false;
            this.lstvwFileDaCopiare.View = System.Windows.Forms.View.Details;
            this.lstvwFileDaCopiare.SelectedIndexChanged += new System.EventHandler(this.lstvwFileDaCopiare_SelectedIndexChanged);
            this.lstvwFileDaCopiare.DoubleClick += new System.EventHandler(this.lstvwFileDaCopiare_DoubleClick);
            this.lstvwFileDaCopiare.Enter += new System.EventHandler(this.lstvwFileDaCopiare_Enter);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File da copiare";
            this.columnHeader1.Width = 299;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cartella ove copiare";
            this.columnHeader2.Width = 253;
            // 
            // btnCartellaPerCopiare
            // 
            this.btnCartellaPerCopiare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartellaPerCopiare.Location = new System.Drawing.Point(360, 245);
            this.btnCartellaPerCopiare.Name = "btnCartellaPerCopiare";
            this.btnCartellaPerCopiare.Size = new System.Drawing.Size(85, 21);
            this.btnCartellaPerCopiare.TabIndex = 55;
            this.btnCartellaPerCopiare.Text = "Scegli cartella";
            this.btnCartellaPerCopiare.UseVisualStyleBackColor = true;
            this.btnCartellaPerCopiare.Click += new System.EventHandler(this.btnCartellaPerCopiare_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "File da copiare";
            // 
            // btnDisabilitaCreare
            // 
            this.btnDisabilitaCreare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDisabilitaCreare.Location = new System.Drawing.Point(201, 245);
            this.btnDisabilitaCreare.Name = "btnDisabilitaCreare";
            this.btnDisabilitaCreare.Size = new System.Drawing.Size(59, 21);
            this.btnDisabilitaCreare.TabIndex = 67;
            this.btnDisabilitaCreare.Text = "Disabilita";
            this.btnDisabilitaCreare.UseVisualStyleBackColor = true;
            this.btnDisabilitaCreare.Click += new System.EventHandler(this.btnDisabilitaCreare_Click);
            // 
            // btnAbilitaCreare
            // 
            this.btnAbilitaCreare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbilitaCreare.Location = new System.Drawing.Point(264, 245);
            this.btnAbilitaCreare.Name = "btnAbilitaCreare";
            this.btnAbilitaCreare.Size = new System.Drawing.Size(59, 21);
            this.btnAbilitaCreare.TabIndex = 66;
            this.btnAbilitaCreare.Text = "Abilita";
            this.btnAbilitaCreare.UseVisualStyleBackColor = true;
            this.btnAbilitaCreare.Click += new System.EventHandler(this.btnAbilitaCreare_Click);
            // 
            // txtNuova
            // 
            this.txtNuova.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNuova.Location = new System.Drawing.Point(2, 219);
            this.txtNuova.Name = "txtNuova";
            this.txtNuova.Size = new System.Drawing.Size(398, 20);
            this.txtNuova.TabIndex = 57;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-1, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nome nuova cartella";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cartelle da creare";
            // 
            // trwCartelleDaCreare
            // 
            this.trwCartelleDaCreare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trwCartelleDaCreare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.trwCartelleDaCreare.CheckBoxes = true;
            this.trwCartelleDaCreare.HideSelection = false;
            this.trwCartelleDaCreare.LabelEdit = true;
            this.trwCartelleDaCreare.Location = new System.Drawing.Point(1, 16);
            this.trwCartelleDaCreare.Name = "trwCartelleDaCreare";
            this.trwCartelleDaCreare.Size = new System.Drawing.Size(399, 184);
            this.trwCartelleDaCreare.TabIndex = 2;
            this.trwCartelleDaCreare.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trwCartelleDaCreare_AfterSelect);
            this.trwCartelleDaCreare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trwCartelleDaCreare_KeyDown);
            // 
            // btnCreaCartella
            // 
            this.btnCreaCartella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreaCartella.Location = new System.Drawing.Point(814, 61);
            this.btnCreaCartella.Name = "btnCreaCartella";
            this.btnCreaCartella.Size = new System.Drawing.Size(83, 22);
            this.btnCreaCartella.TabIndex = 77;
            this.btnCreaCartella.Text = "Crea cartella";
            this.btnCreaCartella.UseVisualStyleBackColor = true;
            this.btnCreaCartella.Click += new System.EventHandler(this.btnCreaCartella_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(202, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 82;
            this.label9.Text = "a";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 162);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 81;
            this.label10.Text = "Da";
            // 
            // txtDiscoVecchio
            // 
            this.txtDiscoVecchio.Location = new System.Drawing.Point(117, 159);
            this.txtDiscoVecchio.Name = "txtDiscoVecchio";
            this.txtDiscoVecchio.Size = new System.Drawing.Size(80, 20);
            this.txtDiscoVecchio.TabIndex = 80;
            // 
            // btnCambiaDisco
            // 
            this.btnCambiaDisco.Location = new System.Drawing.Point(6, 156);
            this.btnCambiaDisco.Name = "btnCambiaDisco";
            this.btnCambiaDisco.Size = new System.Drawing.Size(88, 25);
            this.btnCambiaDisco.TabIndex = 79;
            this.btnCambiaDisco.Text = "Cambia Disco";
            this.btnCambiaDisco.UseVisualStyleBackColor = true;
            this.btnCambiaDisco.Click += new System.EventHandler(this.btnCambiaDisco_Click);
            // 
            // txtDiscoNuovo
            // 
            this.txtDiscoNuovo.Location = new System.Drawing.Point(216, 159);
            this.txtDiscoNuovo.Name = "txtDiscoNuovo";
            this.txtDiscoNuovo.Size = new System.Drawing.Size(80, 20);
            this.txtDiscoNuovo.TabIndex = 78;
            // 
            // frmMakeAllDirs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(951, 460);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDiscoVecchio);
            this.Controls.Add(this.btnCambiaDisco);
            this.Controls.Add(this.txtDiscoNuovo);
            this.Controls.Add(this.btnCreaCartella);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.btnCreaECopia);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFileConfigurazione);
            this.Controls.Add(this.btnNuovo);
            this.Controls.Add(this.btnApriFile);
            this.Controls.Add(this.btnTrovaESostituisci);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnApriFileConfigurazione);
            this.Controls.Add(this.btnEsporta);
            this.Controls.Add(this.btnImporta);
            this.Controls.Add(this.btnLaunchAll);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnCartellaCopia);
            this.Controls.Add(this.btnCartellaRoot);
            this.Controls.Add(this.txtCartellaCopia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRootDir);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMakeAllDirs";
            this.Text = "MakeAllDirs: crea cartelle e copia files";
            this.Load += new System.EventHandler(this.frmMakeAllDirs_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRootDir;
        private System.Windows.Forms.Button btnCreaECopia;
        public System.Windows.Forms.TextBox txtCartellaCopia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMenoCopia;
        private System.Windows.Forms.Button btnPiuCopia;
        private System.Windows.Forms.Button btnCreaCartelle;
        private System.Windows.Forms.Button btnMenoAlbero;
        private System.Windows.Forms.Button btnPiuAlbero;
        private System.Windows.Forms.Button btnCartellaRoot;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnCartellaCopia;
        private System.Windows.Forms.OpenFileDialog opfilScelta;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnPiuInizio;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.Button btnMenoMeno;
        private System.Windows.Forms.Button btnPiuPiu;
        private System.Windows.Forms.Button btnLaunchAll;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnApriFile;
        private System.Windows.Forms.Button btnTrovaESostituisci;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApriFileConfigurazione;
        private System.Windows.Forms.Button btnEsporta;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFileConfigurazione;
        private System.Windows.Forms.SaveFileDialog svfilConfigurazione;
        private System.Windows.Forms.OpenFileDialog opfilConfigurazione;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.ListView lstvwFileDaCopiare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnCartellaPerCopiare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TreeView trwCartelleDaCreare;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNuova;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDeCheckAll;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Button btnDisabilitaCreare;
        private System.Windows.Forms.Button btnAbilitaCreare;
        private System.Windows.Forms.Button btnCheckOff;
        private System.Windows.Forms.Button btnCheckOn;
        private System.Windows.Forms.Button btnCreaCartella;
        private System.Windows.Forms.TextBox txtStringa2Da;
        private System.Windows.Forms.TextBox txtStringa2A;
        private System.Windows.Forms.TextBox txtStringaDa;
        private System.Windows.Forms.TextBox txtStringaA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscoVecchio;
        private System.Windows.Forms.Button btnCambiaDisco;
        private System.Windows.Forms.TextBox txtDiscoNuovo;
    }
}