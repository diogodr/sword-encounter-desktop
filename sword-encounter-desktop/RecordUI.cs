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
    public partial class RecordUI : Form
    {
        CharacterClient characterClient = new CharacterClient();
        public RecordUI()
        {
            InitializeComponent();
            loadChartCharacters();
        }

        private async void loadChartCharacters()
        {
            List<Character> characters = await characterClient.ListCharacters();

            List<int> mounths = new List<int> { };

            for (int i = 1; i <= 12; i++)
            {
                mounths.Add(characters.FindAll(character => character.CreatedAt.Month == i).Count);
            }

            cartesianRecords.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Mês",
                Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"  }
            });

            cartesianRecords.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Usuários"                
            });

            cartesianRecords.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianRecords.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            series.Add(new LineSeries()
            {
                Title = "Qtde de fichas",
                Values = new ChartValues<int>(mounths)
            }); ;

            cartesianRecords.Series = series;
        }
    }
}
