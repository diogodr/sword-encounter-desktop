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
    public partial class MasterUI : Form
    {
        CampaignClient masterClient = new CampaignClient();
        public MasterUI()
        {
            InitializeComponent();
            loadChartCampaigns();
        }

        private async void loadChartCampaigns()
        {
            List<Campaign> users = await masterClient.ListCampaigns();

            List<int> mounths = new List<int> { };

            for (int i = 1; i <= 12; i++)
            {
                mounths.Add(users.FindAll(user => user.CreatedAt.Month == i).Count);
            }

            cartesianMasters.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Mês",
                Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" }
            });

            cartesianMasters.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Usuários"
            });

            cartesianMasters.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianMasters.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            series.Add(new LineSeries()
            {
                Title = "Qtde de Mestres",
                Values = new ChartValues<int>(mounths)
            }); ;

            cartesianMasters.Series = series;
        }
    }
}
