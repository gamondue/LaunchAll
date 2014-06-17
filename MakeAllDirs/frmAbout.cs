using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gamon
{
    public partial class frmAbout : Form
    {

        #region costruttori

        public frmAbout()
		{
            costruttoreGenerale(System.Diagnostics.FileVersionInfo.GetVersionInfo
                    (System.Reflection.Assembly.GetExecutingAssembly().Location).FileDescription
                    , System.Diagnostics.FileVersionInfo.GetVersionInfo
                    (System.Reflection.Assembly.GetExecutingAssembly().Location).Comments
                    , System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
                    , DateCompiled().ToString()
                    , "Ing. Gabriele MONTI"
                    , "Forlì"
                    , "ing@ingmonti.it");
            //lblProgramTitle.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo
            //        (System.Reflection.Assembly.GetExecutingAssembly().Location).FileDescription;
            //lblProgramDescription.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo
            //        (System.Reflection.Assembly.GetExecutingAssembly().Location)
            //        .Comments;
            //lblVersione.Text += System.Diagnostics.FileVersionInfo.GetVersionInfo
            //        (System.Reflection.Assembly.GetExecutingAssembly().Location)
            //        .ProductVersion;
            //lblData.Text = DateCompiled().ToString();
        }

        // TODO vedere se passando l'Assembly è possibile risparmirsi del lavoro dal del programma
        // che chiama questo form
        //public frmAbout(System.Reflection.Assembly Assy)
        //{
        //    lblProgramTitle.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo
        //            (Assy).FileDescription;
        //    lblProgramDescription.Text = System.Diagnostics.FileVersionInfo.GetVersionInfo
        //            (Assy)
        //            .Comments;
        //    lblVersione.Text += System.Diagnostics.FileVersionInfo.GetVersionInfo
        //            (Assy)
        //            .ProductVersion;
        //    lblData.Text = DateCompiled(Assy).ToString();
        //}

        public frmAbout(string programma, string descrizione, string versione,
                        string data, string autore, string città, string email)
        {
            costruttoreGenerale(programma, descrizione, versione,
                        data, autore, città, email);
        }

        private void costruttoreGenerale(string programma, string descrizione, string versione,
                        string data, string autore, string città, string email)
        {
            InitializeComponent();
            lblProgramTitle.Text = programma;
            lblProgramDescription.Text = descrizione;
            lblVersione.Text += versione;
            lblData.Text = data;
            this.Show();
        }
        #endregion

        private void frmAbout_Activated(object sender, System.EventArgs e)
        {
            Timer1.Enabled = false;
            Timer1.Interval = 2000;
            Timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, System.EventArgs e)
        {
            this.Close();
        }

        public DateTime DateCompiled()

        // Assumes that in AssemblyInfo.cs,
        // the version is specified as 1.0.* or the like,
        // with only 2 numbers specified;
        // the next two are generated from the date.
        // This routine decodes them.
        {
            System.Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version; 

            // v.Build is days since Jan. 1, 2000
            // v.Revision*2 is seconds since local midnight
            // (NEVER daylight saving time)

            //DateTime t = new DateTime(
            //    v.Build * TimeSpan.TicksPerDay +
            //    v.Revision * TimeSpan.TicksPerSecond * 2
            //).AddYears(1999);

            DateTime t = new DateTime(
                v.Build * TimeSpan.TicksPerDay).AddYears(1999);

            return t;
        }
    }
}
