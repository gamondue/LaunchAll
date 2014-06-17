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
    public partial class frmSostituzione : Form
    {
        string nomeEPath;
        public frmSostituzione(string NomeEPath)
        {
            InitializeComponent();
            nomeEPath = NomeEPath;
        }

        private void btnSostituisci_Click(object sender, EventArgs e)
        {
            //string fileContent = gamon.FileDiTesto.FileInStringa(nomeEPath);
            //fileContent.Replace(txtCerca.Text, txtSostituisce.Text);
            //gamon.FileDiTesto.StringaInFile(nomeEPath,fileContent,false);

            Encoding fileEncoding = Encoding.Default;
            FileStream fs = new FileStream(nomeEPath, FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader sr = new StreamReader(fs, fileEncoding, true);

            string tuttoIlfile = sr.ReadToEnd(); 
            sr.Close();
            
            fs = new FileStream(nomeEPath, FileMode.Open, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fs, fileEncoding);

            sw.Write(tuttoIlfile.Replace(txtCerca.Text, txtSostituisce.Text)); 
            sw.Close();

            this.Hide();
        }

        private void btnAnnulla_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
