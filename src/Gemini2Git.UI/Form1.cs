using Gemini2Git.Objekte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gemini2Git.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = "";
        }

        private void btnAktualisieren_Click(object sender, EventArgs e)
        {
            Interaktor ia = new Interaktor();
            List<GruppeNameWert> gruppeNameWerts =  ia.Liefere_Git_Eintraege_für_Kopfzeile(txtGemini.Text, "Config/Konfiguration.json", "Branches");
            dgvGit.DataSource = gruppeNameWerts;
            dgvGit.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvGit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string text = dgvGit.Rows[e.RowIndex].Cells[2].Value.ToString();
                Clipboard.SetText(text);
                lblStatus.Text = text;

            }
        }

        
    }
}
