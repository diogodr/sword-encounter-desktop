using LiveCharts;
using LiveCharts.Wpf;
using sword_encounter_desktop.Client;
using sword_encounter_desktop.Models;
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
    public partial class PlayerUI : Form
    {
        CharacterClient characterClient = new CharacterClient();
        public PlayerUI()
        {
            InitializeComponent();
            loadChartPlayers();
        }

        private async void loadChartPlayers()
        {
            List<Character> users = await characterClient.ListPlayers();

            List<int> mounths = new List<int> { };

            for (int i = 1; i <= 12; i++)
            {
                mounths.Add(users.FindAll(user => user.CreatedAt.Month == i).Count);
            }

            cartesianPlayers.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Mês",
                Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" }
            });

            cartesianPlayers.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Usuários"
            });

            cartesianPlayers.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianPlayers.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            series.Add(new LineSeries()
            {
                Title = "Qtde de jogadores",
                Values = new ChartValues<int>(mounths)
            }); ;

            cartesianPlayers.Series = series;
        }
    }
}
