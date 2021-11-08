using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sword_encounter_desktop
{
    public partial class HomeUI : Form
    {
        public HomeUI()
        {
            InitializeComponent();
        }

        private Form Screen;

        private void buttonUsuarios_Click(object sender, EventArgs e)
        {
            Screen?.Close();
            Screen = new UserUI
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panelHome.Controls.Add(Screen);
            Screen.Show();
        }

        private void buttonJogadores_Click(object sender, EventArgs e)
        {
            Screen?.Close();
            Screen = new PlayerUI
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panelHome.Controls.Add(Screen);
            Screen.Show();
        }

        private void buttonFichas_Click(object sender, EventArgs e)
        {
            Screen?.Close();
            Screen = new RecordUI
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panelHome.Controls.Add(Screen);
            Screen.Show();
        }

        private void buttonCampanhas_Click(object sender, EventArgs e)
        {
            Screen?.Close();
            Screen = new CampaignUI
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panelHome.Controls.Add(Screen);
            Screen.Show();
        }

        private void buttonMestres_Click_1(object sender, EventArgs e)
        {
            Screen?.Close();
            Screen = new MasterUI
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            panelHome.Controls.Add(Screen);
            Screen.Show();
        }
    }
}
