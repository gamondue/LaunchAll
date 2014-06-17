namespace LaunchAll
{
    partial class frmMakeAllDir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMakeAllDir));
            this.trwCartelleDaCreare = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRootDir = new System.Windows.Forms.TextBox();
            this.btnCreaECopia = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCartellaCopia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCartellaPerCopiare = new System.Windows.Forms.Button();
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
            this.cklstFileDaCopiare = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txtNuova = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnPiuInizio = new System.Windows.Forms.Button();
            this.btnCopia = new System.Windows.Forms.Button();
            this.btnMenoMeno = new System.Windows.Forms.Button();
            this.btnPiuPiu = new System.Windows.Forms.Button();
            this.btnLaunchAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trwCartelleDaCreare
            // 
            this.trwCartelleDaCreare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trwCartelleDaCreare.CheckBoxes = true;
            this.trwCartelleDaCreare.HideSelection = false;
            this.trwCartelleDaCreare.LabelEdit = true;
            this.trwCartelleDaCreare.Location = new System.Drawing.Point(563, 156);
            this.trwCartelleDaCreare.Name = "trwCartelleDaCreare";
            this.trwCartelleDaCreare.Size = new System.Drawing.Size(423, 254);
            this.trwCartelleDaCreare.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cartelle da creare";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cartella di partenza in cui creare cartelle e file";
            // 
            // txtRootDir
            // 
            this.txtRootDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRootDir.Location = new System.Drawing.Point(3, 35);
            this.txtRootDir.Name = "txtRootDir";
            this.txtRootDir.Size = new System.Drawing.Size(983, 20);
            this.txtRootDir.TabIndex = 3;
            this.txtRootDir.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtRootDir_MouseDoubleClick);
            // 
            // btnCreaECopia
            // 
            this.btnCreaECopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreaECopia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCreaECopia.ForeColor = System.Drawing.Color.White;
            this.btnCreaECopia.Location = new System.Drawing.Point(908, 6);
            this.btnCreaECopia.Name = "btnCreaECopia";
            this.btnCreaECopia.Size = new System.Drawing.Size(78, 28);
            this.btnCreaECopia.TabIndex = 5;
            this.btnCreaECopia.Text = "Crea e copia";
            this.btnCreaECopia.UseVisualStyleBackColor = false;
            this.btnCreaECopia.Click += new System.EventHandler(this.btnCreaECopia_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "File da copiare";
            // 
            // txtCartellaCopia
            // 
            this.txtCartellaCopia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCartellaCopia.Location = new System.Drawing.Point(3, 76);
            this.txtCartellaCopia.Name = "txtCartellaCopia";
            this.txtCartellaCopia.Size = new System.Drawing.Size(983, 20);
            this.txtCartellaCopia.TabIndex = 8;
            this.txtCartellaCopia.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtCartellaCopia_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cartella da cui copiare file";
            // 
            // btnCartellaPerCopiare
            // 
            this.btnCartellaPerCopiare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCartellaPerCopiare.Location = new System.Drawing.Point(478, 438);
            this.btnCartellaPerCopiare.Name = "btnCartellaPerCopiare";
            this.btnCartellaPerCopiare.Size = new System.Drawing.Size(85, 21);
            this.btnCartellaPerCopiare.TabIndex = 46;
            this.btnCartellaPerCopiare.Text = "Scegli cartella";
            this.btnCartellaPerCopiare.UseVisualStyleBackColor = true;
            this.btnCartellaPerCopiare.Click += new System.EventHandler(this.btnCartellaPerCopiare_Click);
            // 
            // btnMenoCopia
            // 
            this.btnMenoCopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenoCopia.Location = new System.Drawing.Point(36, 438);
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
            this.btnPiuCopia.Location = new System.Drawing.Point(6, 438);
            this.btnPiuCopia.Name = "btnPiuCopia";
            this.btnPiuCopia.Size = new System.Drawing.Size(24, 21);
            this.btnPiuCopia.TabIndex = 44;
            this.btnPiuCopia.Text = "+";
            this.btnPiuCopia.UseVisualStyleBackColor = true;
            this.btnPiuCopia.Click += new System.EventHandler(this.btnPiuCopia_Click);
            // 
            // btnCreaCartelle
            // 
            this.btnCreaCartelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreaCartelle.Location = new System.Drawing.Point(908, 438);
            this.btnCreaCartelle.Name = "btnCreaCartelle";
            this.btnCreaCartelle.Size = new System.Drawing.Size(78, 21);
            this.btnCreaCartelle.TabIndex = 49;
            this.btnCreaCartelle.Text = "Crea cartelle";
            this.btnCreaCartelle.UseVisualStyleBackColor = true;
            this.btnCreaCartelle.Click += new System.EventHandler(this.btnCreaCartelle_Click);
            // 
            // btnMenoAlbero
            // 
            this.btnMenoAlbero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenoAlbero.Location = new System.Drawing.Point(654, 438);
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
            this.btnPiuAlbero.Location = new System.Drawing.Point(624, 438);
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
            this.btnCartellaRoot.Location = new System.Drawing.Point(865, 9);
            this.btnCartellaRoot.Name = "btnCartellaRoot";
            this.btnCartellaRoot.Size = new System.Drawing.Size(37, 25);
            this.btnCartellaRoot.TabIndex = 50;
            this.btnCartellaRoot.Text = "..";
            this.btnCartellaRoot.UseVisualStyleBackColor = true;
            this.btnCartellaRoot.Click += new System.EventHandler(this.btnCartellaRoot_Click);
            // 
            // btnCartellaCopia
            // 
            this.btnCartellaCopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCartellaCopia.Location = new System.Drawing.Point(865, 53);
            this.btnCartellaCopia.Name = "btnCartellaCopia";
            this.btnCartellaCopia.Size = new System.Drawing.Size(37, 25);
            this.btnCartellaCopia.TabIndex = 51;
            this.btnCartellaCopia.Text = "..";
            this.btnCartellaCopia.UseVisualStyleBackColor = true;
            this.btnCartellaCopia.Click += new System.EventHandler(this.btnCartellaCopia_Click);
            // 
            // opfilScelta
            // 
            this.opfilScelta.FileName = "da_aprire.lall";
            // 
            // txtEdit
            // 
            this.txtEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdit.Location = new System.Drawing.Point(3, 111);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(983, 20);
            this.txtEdit.TabIndex = 52;
            // 
            // cklstFileDaCopiare
            // 
            this.cklstFileDaCopiare.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cklstFileDaCopiare.CheckBoxes = true;
            this.cklstFileDaCopiare.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.cklstFileDaCopiare.Location = new System.Drawing.Point(3, 156);
            this.cklstFileDaCopiare.Name = "cklstFileDaCopiare";
            this.cklstFileDaCopiare.Size = new System.Drawing.Size(560, 241);
            this.cklstFileDaCopiare.TabIndex = 53;
            this.cklstFileDaCopiare.UseCompatibleStateImageBehavior = false;
            this.cklstFileDaCopiare.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File da copiare";
            this.columnHeader1.Width = 302;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Cartella ove copiare";
            this.columnHeader2.Width = 253;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 54;
            this.label5.Text = "Nome nuova cartella";
            // 
            // txtNuova
            // 
            this.txtNuova.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNuova.Location = new System.Drawing.Point(681, 416);
            this.txtNuova.Name = "txtNuova";
            this.txtNuova.Size = new System.Drawing.Size(305, 20);
            this.txtNuova.TabIndex = 55;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox1.Location = new System.Drawing.Point(295, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 20);
            this.textBox1.TabIndex = 56;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Location = new System.Drawing.Point(3, 416);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 400);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Sostituzione durante la copia. Stringa Da: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Stringa A: ";
            // 
            // btnPiuInizio
            // 
            this.btnPiuInizio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPiuInizio.Location = new System.Drawing.Point(569, 438);
            this.btnPiuInizio.Name = "btnPiuInizio";
            this.btnPiuInizio.Size = new System.Drawing.Size(49, 21);
            this.btnPiuInizio.TabIndex = 60;
            this.btnPiuInizio.Text = "+ inizio";
            this.btnPiuInizio.UseVisualStyleBackColor = true;
            this.btnPiuInizio.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCopia
            // 
            this.btnCopia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopia.Location = new System.Drawing.Point(387, 438);
            this.btnCopia.Name = "btnCopia";
            this.btnCopia.Size = new System.Drawing.Size(85, 21);
            this.btnCopia.TabIndex = 61;
            this.btnCopia.Text = "Copia files";
            this.btnCopia.UseVisualStyleBackColor = true;
            this.btnCopia.Click += new System.EventHandler(this.btnCopia_Click);
            // 
            // btnMenoMeno
            // 
            this.btnMenoMeno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMenoMeno.Location = new System.Drawing.Point(737, 438);
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
            this.btnPiuPiu.Location = new System.Drawing.Point(699, 438);
            this.btnPiuPiu.Name = "btnPiuPiu";
            this.btnPiuPiu.Size = new System.Drawing.Size(32, 21);
            this.btnPiuPiu.TabIndex = 62;
            this.btnPiuPiu.Text = "++";
            this.btnPiuPiu.UseVisualStyleBackColor = true;
            this.btnPiuPiu.Click += new System.EventHandler(this.btnPiuPiu_Click);
            // 
            // btnLaunchAll
            // 
            this.btnLaunchAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLaunchAll.ForeColor = System.Drawing.Color.White;
            this.btnLaunchAll.Location = new System.Drawing.Point(237, 6);
            this.btnLaunchAll.Name = "btnLaunchAll";
            this.btnLaunchAll.Size = new System.Drawing.Size(78, 28);
            this.btnLaunchAll.TabIndex = 64;
            this.btnLaunchAll.Text = "LaunchAll";
            this.btnLaunchAll.UseVisualStyleBackColor = false;
            // 
            // frmMakeAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(988, 461);
            this.Controls.Add(this.btnLaunchAll);
            this.Controls.Add(this.btnMenoMeno);
            this.Controls.Add(this.btnPiuPiu);
            this.Controls.Add(this.btnCopia);
            this.Controls.Add(this.btnPiuInizio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtNuova);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cklstFileDaCopiare);
            this.Controls.Add(this.txtEdit);
            this.Controls.Add(this.btnCartellaCopia);
            this.Controls.Add(this.btnCartellaRoot);
            this.Controls.Add(this.btnCreaCartelle);
            this.Controls.Add(this.btnMenoAlbero);
            this.Controls.Add(this.btnPiuAlbero);
            this.Controls.Add(this.btnCartellaPerCopiare);
            this.Controls.Add(this.btnMenoCopia);
            this.Controls.Add(this.btnPiuCopia);
            this.Controls.Add(this.txtCartellaCopia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCreaECopia);
            this.Controls.Add(this.txtRootDir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trwCartelleDaCreare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMakeAll";
            this.Text = "MaleAll: crea cartelle e copia files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView trwCartelleDaCreare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtRootDir;
        private System.Windows.Forms.Button btnCreaECopia;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtCartellaCopia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCartellaPerCopiare;
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
        public System.Windows.Forms.ListView cklstFileDaCopiare;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNuova;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPiuInizio;
        private System.Windows.Forms.Button btnCopia;
        private System.Windows.Forms.Button btnMenoMeno;
        private System.Windows.Forms.Button btnPiuPiu;
        private System.Windows.Forms.Button btnLaunchAll;
    }
}