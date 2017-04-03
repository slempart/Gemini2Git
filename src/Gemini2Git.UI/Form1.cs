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
            Aktualisieren();
        }

        private void Aktualisieren()
        {
            try
            {
                Interaktor ia = new Interaktor();
                string filterGruppe = GetFilterGruppe();
                List<GruppeNameWert> gruppeNameWerts = ia.Liefere_Git_Eintraege_für_Kopfzeile(txtGemini.Text, "Config/Konfiguration.json", filterGruppe);
                dgvGit.DataSource = gruppeNameWerts;
                dgvGit.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                txtGemini.ForeColor = SystemColors.WindowText;
            }
            catch
            { txtGemini.ForeColor = Color.Red; }
        }

        private string GetFilterGruppe()
        {
            foreach (Control ctl in grpBox.Controls)
            {
                RadioButton rb = ctl as RadioButton;
                if (rb != null)
                {
                    if (rb.Checked)
                    {
                        return rb.Text;
                    } 
                }
            }

            return null;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Interaktor ia = new Interaktor();
            List<Gruppe> gruppen = ia.Liefere_Gruppen("Config/Konfiguration.json");

            int x = 10;// grpBox.Location.X;
            int y = 0; // grpBox.Location.Y;

            foreach (Gruppe gruppe in gruppen)
            {
                y = y + 20;
                RadioButton rb = new RadioButton() { Text = gruppe.GruppenName, Location = new Point(x, y), Font = new Font("", 12), Size = new Size(width: 120, height:25) };
                rb.CheckedChanged += RadioButton_CheckedChanged;
                grpBox.Controls.Add(rb);
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Aktualisieren();
        }

        private void txtGemini_TextChanged(object sender, EventArgs e)
        {
            Aktualisieren();
        }
    }
}
