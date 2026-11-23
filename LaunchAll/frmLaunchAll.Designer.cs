namespace LaunchAll
{
    partial class frmLaunchAll
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaunchAll));
            btnImporta = new Button();
            btnEsporta = new Button();
            btnCreaCartelle = new Button();
            btnApriTutti = new Button();
            folderBrowserDialog = new FolderBrowserDialog();
            btnSalva = new Button();
            btnApriFileConfigurazione = new Button();
            label4 = new Label();
            txtFileConfigurazione = new TextBox();
            svfilConfigurazione = new SaveFileDialog();
            opfilConfigurazione = new OpenFileDialog();
            txtEdit = new TextBox();
            btnTrovaESostituisci = new Button();
            btnApriFile = new Button();
            opfilScelta = new OpenFileDialog();
            btnApri1 = new Button();
            btnMeno1 = new Button();
            btnPiu1 = new Button();
            btnApri2 = new Button();
            btnMeno2 = new Button();
            btnPiu2 = new Button();
            btnApri3 = new Button();
            btnMeno3 = new Button();
            btnPiu3 = new Button();
            btnNuovo = new Button();
            btnApri4 = new Button();
            btnMeno4 = new Button();
            btnPiu4 = new Button();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            txtDisco1 = new TextBox();
            btnConfigura1 = new Button();
            btnCartella1 = new Button();
            label2 = new Label();
            txtCartella1 = new TextBox();
            lstvw1 = new ListView();
            columnHeader5 = new ColumnHeader();
            btnDeCheckAll1 = new Button();
            btnCheckAll1 = new Button();
            txtDisco2 = new TextBox();
            btnConfigura2 = new Button();
            btnCartella2 = new Button();
            label3 = new Label();
            txtCartella2 = new TextBox();
            lstvw2 = new ListView();
            columnHeader6 = new ColumnHeader();
            btnDeCheckAll2 = new Button();
            btnCheckAll2 = new Button();
            splitContainer3 = new SplitContainer();
            txtDisco3 = new TextBox();
            btnConfigura3 = new Button();
            btnCartella3 = new Button();
            txtCartella3 = new TextBox();
            label5 = new Label();
            lstvw3 = new ListView();
            columnHeader7 = new ColumnHeader();
            btnDeCheckAll3 = new Button();
            btnCheckAll3 = new Button();
            txtDisco4 = new TextBox();
            btnConfigura4 = new Button();
            btnCartella4 = new Button();
            txtCartella4 = new TextBox();
            label6 = new Label();
            lstvw4 = new ListView();
            columnHeader8 = new ColumnHeader();
            btnDeCheckAll4 = new Button();
            btnCheckAll4 = new Button();
            txtDiscoNuovo = new TextBox();
            btnCambiaDisco = new Button();
            txtDiscoVecchio = new TextBox();
            label1 = new Label();
            label7 = new Label();
            grpFileConfigurazione = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            grpFileConfigurazione.SuspendLayout();
            SuspendLayout();
            // 
            // btnImporta
            // 
            btnImporta.Location = new Point(402, 15);
            btnImporta.Margin = new Padding(4);
            btnImporta.Name = "btnImporta";
            btnImporta.Size = new Size(91, 32);
            btnImporta.TabIndex = 2;
            btnImporta.Text = "Importa";
            btnImporta.UseVisualStyleBackColor = true;
            btnImporta.Click += btnImporta_Click;
            // 
            // btnEsporta
            // 
            btnEsporta.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEsporta.Location = new Point(273, 15);
            btnEsporta.Margin = new Padding(4);
            btnEsporta.Name = "btnEsporta";
            btnEsporta.Size = new Size(122, 32);
            btnEsporta.TabIndex = 3;
            btnEsporta.Text = "Salva con nome";
            btnEsporta.UseVisualStyleBackColor = true;
            btnEsporta.Click += btnEsporta_Click;
            // 
            // btnCreaCartelle
            // 
            btnCreaCartelle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCreaCartelle.BackColor = Color.FromArgb(192, 0, 0);
            btnCreaCartelle.ForeColor = Color.White;
            btnCreaCartelle.Location = new Point(886, 15);
            btnCreaCartelle.Margin = new Padding(4);
            btnCreaCartelle.Name = "btnCreaCartelle";
            btnCreaCartelle.Size = new Size(91, 32);
            btnCreaCartelle.TabIndex = 4;
            btnCreaCartelle.Text = "MakeAllDirs";
            btnCreaCartelle.UseVisualStyleBackColor = false;
            btnCreaCartelle.Visible = false;
            btnCreaCartelle.Click += btnCreaCartelle_Click;
            // 
            // btnApriTutti
            // 
            btnApriTutti.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnApriTutti.BackColor = Color.FromArgb(0, 192, 0);
            btnApriTutti.ForeColor = Color.White;
            btnApriTutti.Location = new Point(1011, 15);
            btnApriTutti.Margin = new Padding(4);
            btnApriTutti.Name = "btnApriTutti";
            btnApriTutti.Size = new Size(90, 32);
            btnApriTutti.TabIndex = 8;
            btnApriTutti.Text = "Apri tutti";
            btnApriTutti.UseVisualStyleBackColor = false;
            btnApriTutti.Click += btnApriTutti_Click;
            // 
            // btnSalva
            // 
            btnSalva.Location = new Point(692, 15);
            btnSalva.Margin = new Padding(4);
            btnSalva.Name = "btnSalva";
            btnSalva.Size = new Size(91, 32);
            btnSalva.TabIndex = 17;
            btnSalva.Text = "Salva";
            btnSalva.UseVisualStyleBackColor = true;
            btnSalva.Click += btnSalva_Click;
            // 
            // btnApriFileConfigurazione
            // 
            btnApriFileConfigurazione.Location = new Point(788, 15);
            btnApriFileConfigurazione.Margin = new Padding(4);
            btnApriFileConfigurazione.Name = "btnApriFileConfigurazione";
            btnApriFileConfigurazione.Size = new Size(91, 32);
            btnApriFileConfigurazione.TabIndex = 16;
            btnApriFileConfigurazione.Text = "Scegli file";
            btnApriFileConfigurazione.UseVisualStyleBackColor = true;
            btnApriFileConfigurazione.Click += btnApriFileConfigurazione_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 26);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 15;
            label4.Text = "File di configurazione";
            // 
            // txtFileConfigurazione
            // 
            txtFileConfigurazione.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFileConfigurazione.Location = new Point(8, 50);
            txtFileConfigurazione.Margin = new Padding(4);
            txtFileConfigurazione.Name = "txtFileConfigurazione";
            txtFileConfigurazione.Size = new Size(972, 23);
            txtFileConfigurazione.TabIndex = 0;
            txtFileConfigurazione.TextChanged += txtFileConfigurazione_TextChanged;
            // 
            // svfilConfigurazione
            // 
            svfilConfigurazione.FileName = "da_aprire.lall";
            // 
            // opfilConfigurazione
            // 
            opfilConfigurazione.FileName = "da_aprire.lall";
            // 
            // txtEdit
            // 
            txtEdit.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEdit.Location = new Point(315, 82);
            txtEdit.Margin = new Padding(4);
            txtEdit.Name = "txtEdit";
            txtEdit.ReadOnly = true;
            txtEdit.Size = new Size(784, 23);
            txtEdit.TabIndex = 34;
            txtEdit.MouseDoubleClick += txtEdit_MouseDoubleClick;
            // 
            // btnTrovaESostituisci
            // 
            btnTrovaESostituisci.Enabled = false;
            btnTrovaESostituisci.Location = new Point(144, 15);
            btnTrovaESostituisci.Margin = new Padding(4);
            btnTrovaESostituisci.Name = "btnTrovaESostituisci";
            btnTrovaESostituisci.Size = new Size(122, 32);
            btnTrovaESostituisci.TabIndex = 35;
            btnTrovaESostituisci.Text = "Trova e sostituisci";
            btnTrovaESostituisci.UseVisualStyleBackColor = true;
            btnTrovaESostituisci.Click += btnTrovaESostituisci_Click;
            // 
            // btnApriFile
            // 
            btnApriFile.Location = new Point(595, 15);
            btnApriFile.Margin = new Padding(4);
            btnApriFile.Name = "btnApriFile";
            btnApriFile.Size = new Size(91, 32);
            btnApriFile.TabIndex = 36;
            btnApriFile.Text = "Apri";
            btnApriFile.UseVisualStyleBackColor = true;
            btnApriFile.Click += btnApriFile_Click;
            // 
            // opfilScelta
            // 
            opfilScelta.FileName = "da_aprire.lall";
            // 
            // btnApri1
            // 
            btnApri1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApri1.Location = new Point(205, 409);
            btnApri1.Margin = new Padding(4);
            btnApri1.Name = "btnApri1";
            btnApri1.Size = new Size(50, 23);
            btnApri1.TabIndex = 43;
            btnApri1.Text = "Apri";
            btnApri1.UseVisualStyleBackColor = true;
            btnApri1.Click += btnApriCartella_Click;
            // 
            // btnMeno1
            // 
            btnMeno1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMeno1.Location = new Point(34, 409);
            btnMeno1.Margin = new Padding(4);
            btnMeno1.Name = "btnMeno1";
            btnMeno1.Size = new Size(34, 23);
            btnMeno1.TabIndex = 42;
            btnMeno1.Text = "-";
            btnMeno1.UseVisualStyleBackColor = true;
            btnMeno1.Click += btnMeno_Click;
            // 
            // btnPiu1
            // 
            btnPiu1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiu1.Location = new Point(0, 409);
            btnPiu1.Margin = new Padding(4);
            btnPiu1.Name = "btnPiu1";
            btnPiu1.Size = new Size(34, 23);
            btnPiu1.TabIndex = 41;
            btnPiu1.Text = "+";
            btnPiu1.UseVisualStyleBackColor = true;
            btnPiu1.Click += btnPiu_Click;
            // 
            // btnApri2
            // 
            btnApri2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApri2.Location = new Point(220, 409);
            btnApri2.Margin = new Padding(4);
            btnApri2.Name = "btnApri2";
            btnApri2.Size = new Size(50, 23);
            btnApri2.TabIndex = 46;
            btnApri2.Text = "Apri";
            btnApri2.UseVisualStyleBackColor = true;
            btnApri2.Click += btnApriCartella_Click;
            // 
            // btnMeno2
            // 
            btnMeno2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMeno2.Location = new Point(34, 409);
            btnMeno2.Margin = new Padding(4);
            btnMeno2.Name = "btnMeno2";
            btnMeno2.Size = new Size(34, 23);
            btnMeno2.TabIndex = 45;
            btnMeno2.Text = "-";
            btnMeno2.UseVisualStyleBackColor = true;
            btnMeno2.Click += btnMeno_Click;
            // 
            // btnPiu2
            // 
            btnPiu2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiu2.Location = new Point(0, 409);
            btnPiu2.Margin = new Padding(4);
            btnPiu2.Name = "btnPiu2";
            btnPiu2.Size = new Size(34, 23);
            btnPiu2.TabIndex = 44;
            btnPiu2.Text = "+";
            btnPiu2.UseVisualStyleBackColor = true;
            btnPiu2.Click += btnPiu_Click;
            // 
            // btnApri3
            // 
            btnApri3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApri3.Location = new Point(214, 409);
            btnApri3.Margin = new Padding(4);
            btnApri3.Name = "btnApri3";
            btnApri3.Size = new Size(50, 23);
            btnApri3.TabIndex = 49;
            btnApri3.Text = "Apri";
            btnApri3.UseVisualStyleBackColor = true;
            btnApri3.Click += btnApriCartella_Click;
            // 
            // btnMeno3
            // 
            btnMeno3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMeno3.Location = new Point(34, 409);
            btnMeno3.Margin = new Padding(4);
            btnMeno3.Name = "btnMeno3";
            btnMeno3.Size = new Size(34, 23);
            btnMeno3.TabIndex = 48;
            btnMeno3.Text = "-";
            btnMeno3.UseVisualStyleBackColor = true;
            btnMeno3.Click += btnMeno_Click;
            // 
            // btnPiu3
            // 
            btnPiu3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiu3.Location = new Point(0, 409);
            btnPiu3.Margin = new Padding(4);
            btnPiu3.Name = "btnPiu3";
            btnPiu3.Size = new Size(34, 23);
            btnPiu3.TabIndex = 47;
            btnPiu3.Text = "+";
            btnPiu3.UseVisualStyleBackColor = true;
            btnPiu3.Click += btnPiu_Click;
            // 
            // btnNuovo
            // 
            btnNuovo.Location = new Point(498, 15);
            btnNuovo.Margin = new Padding(4);
            btnNuovo.Name = "btnNuovo";
            btnNuovo.Size = new Size(91, 32);
            btnNuovo.TabIndex = 50;
            btnNuovo.Text = "Nuovo";
            btnNuovo.UseVisualStyleBackColor = true;
            btnNuovo.Click += btnNuovo_Click;
            // 
            // btnApri4
            // 
            btnApri4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnApri4.Location = new Point(222, 409);
            btnApri4.Margin = new Padding(4);
            btnApri4.Name = "btnApri4";
            btnApri4.Size = new Size(50, 23);
            btnApri4.TabIndex = 56;
            btnApri4.Text = "Apri";
            btnApri4.UseVisualStyleBackColor = true;
            btnApri4.Click += btnApriCartella_Click;
            // 
            // btnMeno4
            // 
            btnMeno4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnMeno4.Location = new Point(33, 409);
            btnMeno4.Margin = new Padding(4);
            btnMeno4.Name = "btnMeno4";
            btnMeno4.Size = new Size(34, 23);
            btnMeno4.TabIndex = 55;
            btnMeno4.Text = "-";
            btnMeno4.UseVisualStyleBackColor = true;
            btnMeno4.Click += btnMeno_Click;
            // 
            // btnPiu4
            // 
            btnPiu4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnPiu4.Location = new Point(-1, 409);
            btnPiu4.Margin = new Padding(4);
            btnPiu4.Name = "btnPiu4";
            btnPiu4.Size = new Size(34, 23);
            btnPiu4.TabIndex = 54;
            btnPiu4.Text = "+";
            btnPiu4.UseVisualStyleBackColor = true;
            btnPiu4.Click += btnPiu_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(10, 112);
            splitContainer1.Margin = new Padding(4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer3);
            splitContainer1.Size = new Size(1096, 436);
            splitContainer1.SplitterDistance = 540;
            splitContainer1.TabIndex = 61;
            // 
            // splitContainer2
            // 
            splitContainer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer2.Location = new Point(1, 0);
            splitContainer2.Margin = new Padding(4);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtDisco1);
            splitContainer2.Panel1.Controls.Add(btnConfigura1);
            splitContainer2.Panel1.Controls.Add(btnCartella1);
            splitContainer2.Panel1.Controls.Add(label2);
            splitContainer2.Panel1.Controls.Add(txtCartella1);
            splitContainer2.Panel1.Controls.Add(lstvw1);
            splitContainer2.Panel1.Controls.Add(btnApri1);
            splitContainer2.Panel1.Controls.Add(btnPiu1);
            splitContainer2.Panel1.Controls.Add(btnMeno1);
            splitContainer2.Panel1.Controls.Add(btnDeCheckAll1);
            splitContainer2.Panel1.Controls.Add(btnCheckAll1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(txtDisco2);
            splitContainer2.Panel2.Controls.Add(btnConfigura2);
            splitContainer2.Panel2.Controls.Add(btnCartella2);
            splitContainer2.Panel2.Controls.Add(label3);
            splitContainer2.Panel2.Controls.Add(txtCartella2);
            splitContainer2.Panel2.Controls.Add(lstvw2);
            splitContainer2.Panel2.Controls.Add(btnApri2);
            splitContainer2.Panel2.Controls.Add(btnPiu2);
            splitContainer2.Panel2.Controls.Add(btnMeno2);
            splitContainer2.Panel2.Controls.Add(btnDeCheckAll2);
            splitContainer2.Panel2.Controls.Add(btnCheckAll2);
            splitContainer2.Size = new Size(536, 436);
            splitContainer2.SplitterDistance = 261;
            splitContainer2.TabIndex = 66;
            // 
            // txtDisco1
            // 
            txtDisco1.Location = new Point(0, 35);
            txtDisco1.Margin = new Padding(4);
            txtDisco1.Name = "txtDisco1";
            txtDisco1.ShortcutsEnabled = false;
            txtDisco1.Size = new Size(67, 23);
            txtDisco1.TabIndex = 68;
            // 
            // btnConfigura1
            // 
            btnConfigura1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfigura1.Enabled = false;
            btnConfigura1.Location = new Point(128, 0);
            btnConfigura1.Margin = new Padding(4);
            btnConfigura1.Name = "btnConfigura1";
            btnConfigura1.Size = new Size(81, 32);
            btnConfigura1.TabIndex = 63;
            btnConfigura1.Text = "Configura";
            btnConfigura1.UseVisualStyleBackColor = true;
            btnConfigura1.Visible = false;
            // 
            // btnCartella1
            // 
            btnCartella1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCartella1.Location = new Point(214, 0);
            btnCartella1.Margin = new Padding(4);
            btnCartella1.Name = "btnCartella1";
            btnCartella1.Size = new Size(43, 32);
            btnCartella1.TabIndex = 62;
            btnCartella1.Text = "..";
            btnCartella1.UseVisualStyleBackColor = true;
            btnCartella1.Click += btnCartella_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 16);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 61;
            label2.Text = "Cartella 1";
            // 
            // txtCartella1
            // 
            txtCartella1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCartella1.Location = new Point(67, 35);
            txtCartella1.Margin = new Padding(4);
            txtCartella1.Name = "txtCartella1";
            txtCartella1.Size = new Size(189, 23);
            txtCartella1.TabIndex = 60;
            txtCartella1.MouseClick += txtCartella_MouseClick;
            txtCartella1.MouseDoubleClick += txtCartella_MouseDoubleClick;
            // 
            // lstvw1
            // 
            lstvw1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvw1.BackColor = Color.FromArgb(255, 255, 128);
            lstvw1.CheckBoxes = true;
            lstvw1.Columns.AddRange(new ColumnHeader[] { columnHeader5 });
            lstvw1.Location = new Point(0, 65);
            lstvw1.Margin = new Padding(4);
            lstvw1.Name = "lstvw1";
            lstvw1.Size = new Size(257, 339);
            lstvw1.TabIndex = 59;
            lstvw1.UseCompatibleStateImageBehavior = false;
            lstvw1.View = View.Details;
            lstvw1.SelectedIndexChanged += lstvw_SelectedIndexChanged;
            lstvw1.DoubleClick += lstvw_DoubleClick;
            lstvw1.Enter += lstvw_Enter;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "File da lanciare";
            columnHeader5.Width = 240;
            // 
            // btnDeCheckAll1
            // 
            btnDeCheckAll1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeCheckAll1.Location = new Point(68, 409);
            btnDeCheckAll1.Margin = new Padding(4);
            btnDeCheckAll1.Name = "btnDeCheckAll1";
            btnDeCheckAll1.Size = new Size(34, 23);
            btnDeCheckAll1.TabIndex = 67;
            btnDeCheckAll1.Text = "off";
            btnDeCheckAll1.UseVisualStyleBackColor = true;
            btnDeCheckAll1.Click += btnDeCheckAll_Click;
            // 
            // btnCheckAll1
            // 
            btnCheckAll1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckAll1.Location = new Point(102, 409);
            btnCheckAll1.Margin = new Padding(4);
            btnCheckAll1.Name = "btnCheckAll1";
            btnCheckAll1.Size = new Size(34, 23);
            btnCheckAll1.TabIndex = 66;
            btnCheckAll1.Text = "on";
            btnCheckAll1.UseVisualStyleBackColor = true;
            btnCheckAll1.Click += btnCheckAll_Click;
            // 
            // txtDisco2
            // 
            txtDisco2.Location = new Point(0, 35);
            txtDisco2.Margin = new Padding(4);
            txtDisco2.Name = "txtDisco2";
            txtDisco2.Size = new Size(67, 23);
            txtDisco2.TabIndex = 68;
            // 
            // btnConfigura2
            // 
            btnConfigura2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfigura2.Enabled = false;
            btnConfigura2.Location = new Point(138, 0);
            btnConfigura2.Margin = new Padding(4);
            btnConfigura2.Name = "btnConfigura2";
            btnConfigura2.Size = new Size(81, 32);
            btnConfigura2.TabIndex = 64;
            btnConfigura2.Text = "Configura";
            btnConfigura2.UseVisualStyleBackColor = true;
            btnConfigura2.Visible = false;
            // 
            // btnCartella2
            // 
            btnCartella2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCartella2.Location = new Point(229, 1);
            btnCartella2.Margin = new Padding(4);
            btnCartella2.Name = "btnCartella2";
            btnCartella2.Size = new Size(43, 31);
            btnCartella2.TabIndex = 63;
            btnCartella2.Text = "..";
            btnCartella2.UseVisualStyleBackColor = true;
            btnCartella2.Click += btnCartella_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 17);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 62;
            label3.Text = "Cartella 2";
            // 
            // txtCartella2
            // 
            txtCartella2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCartella2.Location = new Point(67, 35);
            txtCartella2.Margin = new Padding(4);
            txtCartella2.Name = "txtCartella2";
            txtCartella2.Size = new Size(203, 23);
            txtCartella2.TabIndex = 61;
            txtCartella2.MouseClick += txtCartella_MouseClick;
            txtCartella2.MouseDoubleClick += txtCartella_MouseDoubleClick;
            // 
            // lstvw2
            // 
            lstvw2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvw2.BackColor = Color.FromArgb(255, 255, 128);
            lstvw2.CheckBoxes = true;
            lstvw2.Columns.AddRange(new ColumnHeader[] { columnHeader6 });
            lstvw2.Location = new Point(0, 65);
            lstvw2.Margin = new Padding(4);
            lstvw2.Name = "lstvw2";
            lstvw2.Size = new Size(269, 339);
            lstvw2.TabIndex = 60;
            lstvw2.UseCompatibleStateImageBehavior = false;
            lstvw2.View = View.Details;
            lstvw2.SelectedIndexChanged += lstvw_SelectedIndexChanged;
            lstvw2.DoubleClick += lstvw_DoubleClick;
            lstvw2.Enter += lstvw_Enter;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "File da lanciare";
            columnHeader6.Width = 240;
            // 
            // btnDeCheckAll2
            // 
            btnDeCheckAll2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeCheckAll2.Location = new Point(68, 409);
            btnDeCheckAll2.Margin = new Padding(4);
            btnDeCheckAll2.Name = "btnDeCheckAll2";
            btnDeCheckAll2.Size = new Size(34, 23);
            btnDeCheckAll2.TabIndex = 67;
            btnDeCheckAll2.Text = "off";
            btnDeCheckAll2.UseVisualStyleBackColor = true;
            btnDeCheckAll2.Click += btnDeCheckAll_Click;
            // 
            // btnCheckAll2
            // 
            btnCheckAll2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckAll2.Location = new Point(102, 409);
            btnCheckAll2.Margin = new Padding(4);
            btnCheckAll2.Name = "btnCheckAll2";
            btnCheckAll2.Size = new Size(34, 23);
            btnCheckAll2.TabIndex = 66;
            btnCheckAll2.Text = "on";
            btnCheckAll2.UseVisualStyleBackColor = true;
            btnCheckAll2.Click += btnCheckAll_Click;
            // 
            // splitContainer3
            // 
            splitContainer3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer3.Location = new Point(0, 1);
            splitContainer3.Margin = new Padding(4);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(txtDisco3);
            splitContainer3.Panel1.Controls.Add(btnConfigura3);
            splitContainer3.Panel1.Controls.Add(btnCartella3);
            splitContainer3.Panel1.Controls.Add(txtCartella3);
            splitContainer3.Panel1.Controls.Add(label5);
            splitContainer3.Panel1.Controls.Add(lstvw3);
            splitContainer3.Panel1.Controls.Add(btnApri3);
            splitContainer3.Panel1.Controls.Add(btnPiu3);
            splitContainer3.Panel1.Controls.Add(btnMeno3);
            splitContainer3.Panel1.Controls.Add(btnDeCheckAll3);
            splitContainer3.Panel1.Controls.Add(btnCheckAll3);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(txtDisco4);
            splitContainer3.Panel2.Controls.Add(btnConfigura4);
            splitContainer3.Panel2.Controls.Add(btnCartella4);
            splitContainer3.Panel2.Controls.Add(btnApri4);
            splitContainer3.Panel2.Controls.Add(txtCartella4);
            splitContainer3.Panel2.Controls.Add(btnMeno4);
            splitContainer3.Panel2.Controls.Add(btnPiu4);
            splitContainer3.Panel2.Controls.Add(label6);
            splitContainer3.Panel2.Controls.Add(lstvw4);
            splitContainer3.Panel2.Controls.Add(btnDeCheckAll4);
            splitContainer3.Panel2.Controls.Add(btnCheckAll4);
            splitContainer3.Size = new Size(548, 435);
            splitContainer3.SplitterDistance = 269;
            splitContainer3.TabIndex = 64;
            // 
            // txtDisco3
            // 
            txtDisco3.Location = new Point(0, 35);
            txtDisco3.Margin = new Padding(4);
            txtDisco3.Name = "txtDisco3";
            txtDisco3.Size = new Size(67, 23);
            txtDisco3.TabIndex = 69;
            // 
            // btnConfigura3
            // 
            btnConfigura3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfigura3.Enabled = false;
            btnConfigura3.Location = new Point(134, 0);
            btnConfigura3.Margin = new Padding(4);
            btnConfigura3.Name = "btnConfigura3";
            btnConfigura3.Size = new Size(81, 32);
            btnConfigura3.TabIndex = 63;
            btnConfigura3.Text = "Configura";
            btnConfigura3.UseVisualStyleBackColor = true;
            btnConfigura3.Visible = false;
            // 
            // btnCartella3
            // 
            btnCartella3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCartella3.Location = new Point(221, 0);
            btnCartella3.Margin = new Padding(4);
            btnCartella3.Name = "btnCartella3";
            btnCartella3.Size = new Size(43, 32);
            btnCartella3.TabIndex = 62;
            btnCartella3.Text = "..";
            btnCartella3.UseVisualStyleBackColor = true;
            btnCartella3.Click += btnCartella_Click;
            // 
            // txtCartella3
            // 
            txtCartella3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCartella3.Location = new Point(67, 35);
            txtCartella3.Margin = new Padding(4);
            txtCartella3.Name = "txtCartella3";
            txtCartella3.Size = new Size(197, 23);
            txtCartella3.TabIndex = 61;
            txtCartella3.MouseClick += txtCartella_MouseClick;
            txtCartella3.MouseDoubleClick += txtCartella_MouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 16);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 60;
            label5.Text = "Cartella  3";
            // 
            // lstvw3
            // 
            lstvw3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvw3.BackColor = Color.FromArgb(255, 255, 128);
            lstvw3.CheckBoxes = true;
            lstvw3.Columns.AddRange(new ColumnHeader[] { columnHeader7 });
            lstvw3.Location = new Point(0, 64);
            lstvw3.Margin = new Padding(4);
            lstvw3.Name = "lstvw3";
            lstvw3.Size = new Size(264, 339);
            lstvw3.TabIndex = 59;
            lstvw3.UseCompatibleStateImageBehavior = false;
            lstvw3.View = View.Details;
            lstvw3.SelectedIndexChanged += lstvw_SelectedIndexChanged;
            lstvw3.DoubleClick += lstvw_DoubleClick;
            lstvw3.Enter += lstvw_Enter;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "File da lanciare";
            columnHeader7.Width = 240;
            // 
            // btnDeCheckAll3
            // 
            btnDeCheckAll3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeCheckAll3.Location = new Point(68, 409);
            btnDeCheckAll3.Margin = new Padding(4);
            btnDeCheckAll3.Name = "btnDeCheckAll3";
            btnDeCheckAll3.Size = new Size(34, 23);
            btnDeCheckAll3.TabIndex = 67;
            btnDeCheckAll3.Text = "off";
            btnDeCheckAll3.UseVisualStyleBackColor = true;
            btnDeCheckAll3.Click += btnDeCheckAll_Click;
            // 
            // btnCheckAll3
            // 
            btnCheckAll3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckAll3.Location = new Point(102, 409);
            btnCheckAll3.Margin = new Padding(4);
            btnCheckAll3.Name = "btnCheckAll3";
            btnCheckAll3.Size = new Size(34, 23);
            btnCheckAll3.TabIndex = 66;
            btnCheckAll3.Text = "on";
            btnCheckAll3.UseVisualStyleBackColor = true;
            btnCheckAll3.Click += btnCheckAll_Click;
            // 
            // txtDisco4
            // 
            txtDisco4.Location = new Point(0, 35);
            txtDisco4.Margin = new Padding(4);
            txtDisco4.Name = "txtDisco4";
            txtDisco4.Size = new Size(67, 23);
            txtDisco4.TabIndex = 70;
            // 
            // btnConfigura4
            // 
            btnConfigura4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnConfigura4.Enabled = false;
            btnConfigura4.Location = new Point(145, 0);
            btnConfigura4.Margin = new Padding(4);
            btnConfigura4.Name = "btnConfigura4";
            btnConfigura4.Size = new Size(81, 32);
            btnConfigura4.TabIndex = 64;
            btnConfigura4.Text = "Configura";
            btnConfigura4.UseVisualStyleBackColor = true;
            btnConfigura4.Visible = false;
            // 
            // btnCartella4
            // 
            btnCartella4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCartella4.Location = new Point(229, 0);
            btnCartella4.Margin = new Padding(4);
            btnCartella4.Name = "btnCartella4";
            btnCartella4.Size = new Size(43, 32);
            btnCartella4.TabIndex = 63;
            btnCartella4.Text = "..";
            btnCartella4.UseVisualStyleBackColor = true;
            btnCartella4.Click += btnCartella_Click;
            // 
            // txtCartella4
            // 
            txtCartella4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtCartella4.Location = new Point(67, 35);
            txtCartella4.Margin = new Padding(4);
            txtCartella4.Name = "txtCartella4";
            txtCartella4.Size = new Size(205, 23);
            txtCartella4.TabIndex = 62;
            txtCartella4.MouseClick += txtCartella_MouseClick;
            txtCartella4.MouseDoubleClick += txtCartella_MouseDoubleClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 61;
            label6.Text = "Cartella 4";
            // 
            // lstvw4
            // 
            lstvw4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstvw4.BackColor = Color.FromArgb(255, 255, 128);
            lstvw4.CheckBoxes = true;
            lstvw4.Columns.AddRange(new ColumnHeader[] { columnHeader8 });
            lstvw4.Location = new Point(0, 64);
            lstvw4.Margin = new Padding(4);
            lstvw4.Name = "lstvw4";
            lstvw4.Size = new Size(272, 339);
            lstvw4.TabIndex = 60;
            lstvw4.UseCompatibleStateImageBehavior = false;
            lstvw4.View = View.Details;
            lstvw4.SelectedIndexChanged += lstvw_SelectedIndexChanged;
            lstvw4.DoubleClick += lstvw_DoubleClick;
            lstvw4.Enter += lstvw_Enter;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "File da lanciare";
            columnHeader8.Width = 240;
            // 
            // btnDeCheckAll4
            // 
            btnDeCheckAll4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeCheckAll4.Location = new Point(67, 409);
            btnDeCheckAll4.Margin = new Padding(4);
            btnDeCheckAll4.Name = "btnDeCheckAll4";
            btnDeCheckAll4.Size = new Size(34, 23);
            btnDeCheckAll4.TabIndex = 67;
            btnDeCheckAll4.Text = "off";
            btnDeCheckAll4.UseVisualStyleBackColor = true;
            btnDeCheckAll4.Click += btnDeCheckAll_Click;
            // 
            // btnCheckAll4
            // 
            btnCheckAll4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCheckAll4.Location = new Point(102, 409);
            btnCheckAll4.Margin = new Padding(4);
            btnCheckAll4.Name = "btnCheckAll4";
            btnCheckAll4.Size = new Size(34, 23);
            btnCheckAll4.TabIndex = 66;
            btnCheckAll4.Text = "on";
            btnCheckAll4.UseVisualStyleBackColor = true;
            btnCheckAll4.Click += btnCheckAll_Click;
            // 
            // txtDiscoNuovo
            // 
            txtDiscoNuovo.Location = new Point(234, 82);
            txtDiscoNuovo.Margin = new Padding(4);
            txtDiscoNuovo.Name = "txtDiscoNuovo";
            txtDiscoNuovo.Size = new Size(75, 23);
            txtDiscoNuovo.TabIndex = 2;
            txtDiscoNuovo.MouseClick += txtDiscoNuovo_MouseClick;
            txtDiscoNuovo.TextChanged += txtDiscoNuovo_TextChanged;
            txtDiscoNuovo.Leave += txtDiscoNuovo_Leave;
            // 
            // btnCambiaDisco
            // 
            btnCambiaDisco.Location = new Point(10, 79);
            btnCambiaDisco.Margin = new Padding(4);
            btnCambiaDisco.Name = "btnCambiaDisco";
            btnCambiaDisco.Size = new Size(102, 29);
            btnCambiaDisco.TabIndex = 68;
            btnCambiaDisco.Text = "Cambia Disco";
            btnCambiaDisco.UseVisualStyleBackColor = true;
            btnCambiaDisco.Click += btnCambiaDisco_Click;
            // 
            // txtDiscoVecchio
            // 
            txtDiscoVecchio.Location = new Point(144, 82);
            txtDiscoVecchio.Margin = new Padding(4);
            txtDiscoVecchio.Name = "txtDiscoVecchio";
            txtDiscoVecchio.Size = new Size(75, 23);
            txtDiscoVecchio.TabIndex = 1;
            txtDiscoVecchio.MouseClick += txtDiscoVecchio_MouseClick;
            txtDiscoVecchio.TextChanged += txtDiscoVecchio_TextChanged;
            txtDiscoVecchio.Leave += txtDiscoVecchio_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 85);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 70;
            label1.Text = "Da";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(220, 84);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 71;
            label7.Text = "a";
            // 
            // grpFileConfigurazione
            // 
            grpFileConfigurazione.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpFileConfigurazione.Controls.Add(btnNuovo);
            grpFileConfigurazione.Controls.Add(btnImporta);
            grpFileConfigurazione.Controls.Add(btnEsporta);
            grpFileConfigurazione.Controls.Add(btnApriFileConfigurazione);
            grpFileConfigurazione.Controls.Add(btnSalva);
            grpFileConfigurazione.Controls.Add(btnTrovaESostituisci);
            grpFileConfigurazione.Controls.Add(btnApriFile);
            grpFileConfigurazione.Controls.Add(txtFileConfigurazione);
            grpFileConfigurazione.Controls.Add(label4);
            grpFileConfigurazione.Controls.Add(btnCreaCartelle);
            grpFileConfigurazione.Location = new Point(10, 0);
            grpFileConfigurazione.Name = "grpFileConfigurazione";
            grpFileConfigurazione.Size = new Size(987, 75);
            grpFileConfigurazione.TabIndex = 0;
            grpFileConfigurazione.TabStop = false;
            grpFileConfigurazione.Text = "Operazioni sui file di configurazione del programma";
            // 
            // frmLaunchAll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1110, 555);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(txtDiscoVecchio);
            Controls.Add(btnCambiaDisco);
            Controls.Add(txtDiscoNuovo);
            Controls.Add(splitContainer1);
            Controls.Add(btnApriTutti);
            Controls.Add(txtEdit);
            Controls.Add(grpFileConfigurazione);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "frmLaunchAll";
            Text = "LaunchAll: apre file da più cartelle";
            Load += frmLaunchAll_Load;
            Resize += frmLaunchAll_Resize;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            grpFileConfigurazione.ResumeLayout(false);
            grpFileConfigurazione.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFileConfigurazione;
        private System.Windows.Forms.Button btnImporta;
        private System.Windows.Forms.Button btnEsporta;
        private System.Windows.Forms.Button btnCreaCartelle;
        private System.Windows.Forms.Button btnApriTutti;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApriFileConfigurazione;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileConfigurazione;
        private System.Windows.Forms.SaveFileDialog svfilConfigurazione;
        private System.Windows.Forms.OpenFileDialog opfilConfigurazione;
        private System.Windows.Forms.TextBox txtEdit;
        private System.Windows.Forms.Button btnTrovaESostituisci;
        private System.Windows.Forms.Button btnApriFile;
        private System.Windows.Forms.OpenFileDialog opfilScelta;
        private System.Windows.Forms.Button btnApri1;
        private System.Windows.Forms.Button btnMeno1;
        private System.Windows.Forms.Button btnPiu1;
        private System.Windows.Forms.Button btnApri2;
        private System.Windows.Forms.Button btnMeno2;
        private System.Windows.Forms.Button btnPiu2;
        private System.Windows.Forms.Button btnApri3;
        private System.Windows.Forms.Button btnMeno3;
        private System.Windows.Forms.Button btnPiu3;
        private System.Windows.Forms.Button btnNuovo;
        private System.Windows.Forms.Button btnApri4;
        private System.Windows.Forms.Button btnMeno4;
        private System.Windows.Forms.Button btnPiu4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        public System.Windows.Forms.ListView lstvw3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        public System.Windows.Forms.ListView lstvw4;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnConfigura1;
        private System.Windows.Forms.Button btnCartella1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCartella1;
        public System.Windows.Forms.ListView lstvw1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnConfigura2;
        private System.Windows.Forms.Button btnCartella2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCartella2;
        public System.Windows.Forms.ListView lstvw2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnConfigura3;
        private System.Windows.Forms.Button btnCartella3;
        private System.Windows.Forms.TextBox txtCartella3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConfigura4;
        private System.Windows.Forms.Button btnCartella4;
        private System.Windows.Forms.TextBox txtCartella4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDeCheckAll1;
        private System.Windows.Forms.Button btnCheckAll1;
        private System.Windows.Forms.Button btnDeCheckAll2;
        private System.Windows.Forms.Button btnCheckAll2;
        private System.Windows.Forms.Button btnDeCheckAll3;
        private System.Windows.Forms.Button btnCheckAll3;
        private System.Windows.Forms.Button btnDeCheckAll4;
        private System.Windows.Forms.Button btnCheckAll4;
        private System.Windows.Forms.TextBox txtDiscoNuovo;
        private System.Windows.Forms.Button btnCambiaDisco;
        private System.Windows.Forms.TextBox txtDisco1;
        private System.Windows.Forms.TextBox txtDisco2;
        private System.Windows.Forms.TextBox txtDisco3;
        private System.Windows.Forms.TextBox txtDisco4;
        private System.Windows.Forms.TextBox txtDiscoVecchio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
    }
}

