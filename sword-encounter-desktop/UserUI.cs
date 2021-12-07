using LiveCharts;
using LiveCharts.Wpf;
using sword_encounter_desktop.Client;
using sword_encounter_desktop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sword_encounter_desktop
{
    public partial class UserUI : Form
    {
        UserClient userClient = new UserClient();

        public UserUI()
        {
            InitializeComponent();
            loadChartUsers();
        }    
        private async void loadChartUsers()
        {
            List<User> users = await userClient.ListUsers();

            List<int> mounths = new List<int> { };

            for (int i = 1; i <= 12; i++)
            {
                mounths.Add(users.FindAll(user => user.CreatedAt.Month == i).Count);
            }

            cartesianUsers.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Mês",
                Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"  }
            });

            cartesianUsers.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Usuários"                
            });

            cartesianUsers.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianUsers.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            series.Add(new LineSeries()
            {
                Title = "Qtde de usuários",
                Values = new ChartValues<int>(mounths)
            }); ;

            cartesianUsers.Series = series;
        }
    }
}
