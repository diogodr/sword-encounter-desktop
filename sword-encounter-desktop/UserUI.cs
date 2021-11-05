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
            Debug.WriteLine(users[0].Email);

            cartesianUsers.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Dia",
                Labels = new[] { "1", "2", "3" }
            });

            cartesianUsers.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Usuários",
                LabelFormatter = value => value.ToString("C")
            });

            cartesianUsers.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianUsers.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            series.Add(new LineSeries()
            {
                Title = "Usuários2",
                Values = new ChartValues<double>(new List<double> { 1.0, 2.0, 3.0 })
            });

            cartesianUsers.Series = series;
        }

        private void cartesianUsers_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}
