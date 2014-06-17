namespace LaunchAll
{
    partial class frmConfiguraFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguraFiles));
            this.btnPiu = new System.Windows.Forms.Button();
            this.btnMeno = new System.Windows.Forms.Button();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnApri = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.CheckedListBox();
            this.opfilScelta = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnPiu
            // 
            this.btnPiu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPiu.Location = new System.Drawing.Point(1, 266);
            this.btnPiu.Name = "btnPiu";
            this.btnPiu.Size = new System.Drawing.Size(24, 21);
            this.btnPiu.TabIndex = 3;
            this.btnPiu.Text = "+";
            this.btnPiu.UseVisualStyleBackColor = true;
            this.btnPiu.Click += new System.EventHandler(this.btnPiu_Click);
            // 
            // btnMeno
            // 
            this.btnMeno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnMeno.Location = new System.Drawing.Point(31, 266);
            this.btnMeno.Name = "btnMeno";
            this.btnMeno.Size = new System.Drawing.Size(26, 21);
            this.btnMeno.TabIndex = 4;
            this.btnMeno.Text = "-";
            this.btnMeno.UseVisualStyleBackColor = true;
            this.btnMeno.Click += new System.EventHandler(this.btnMeno_Click);
            // 
            // btnSalva
            // 
            this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalva.Location = new System.Drawing.Point(202, 266);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Size = new System.Drawing.Size(45, 21);
            this.btnSalva.TabIndex = 5;
            this.btnSalva.Text = "Salva";
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnApri
            // 
            this.btnApri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApri.Location = new System.Drawing.Point(151, 266);
            this.btnApri.Name = "btnApri";
            this.btnApri.Size = new System.Drawing.Size(45, 21);
            this.btnApri.TabIndex = 6;
            this.btnApri.Text = "Apri";
            this.btnApri.UseVisualStyleBackColor = true;
            this.btnApri.Click += new System.EventHandler(this.btnApri_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(1, 0);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(246, 259);
            this.lstFiles.TabIndex = 7;
            this.lstFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstFiles_MouseDoubleClick);
            // 
            // frmConfiguraFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(254)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(249, 293);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnApri);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.btnMeno);
            this.Controls.Add(this.btnPiu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConfiguraFiles";
            this.Text = "Apri files";
            this.Load += new System.EventHandler(this.frmApriFiles_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPiu;
        private System.Windows.Forms.Button btnMeno;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnApri;
        private System.Windows.Forms.CheckedListBox lstFiles;
        private System.Windows.Forms.OpenFileDialog opfilScelta;
    }
}