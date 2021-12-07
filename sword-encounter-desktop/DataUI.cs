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
    public partial class DataUI : Form
    {
        UserClient userClient = new UserClient();
        CharacterClient characterClient = new CharacterClient();
        CampaignClient campaignClient = new CampaignClient();
        public DataUI()
        {
            InitializeComponent();
            loadData();
        }

        private async void loadData()
        {
            List<User> users = await userClient.ListUsers();
            List<Campaign> campaigns = await campaignClient.ListCampaigns();
            List<Character> characters = await characterClient.ListCharacters();
            List<Character> players = await characterClient.ListPlayers();

            List<int> userMounths = new List<int> { };
            List<int> campaignMounths = new List<int> { };
            List<int> characterMounths = new List<int> { };
            List<int> playerMounths = new List<int> { };

            for (int i = 1; i <= 12; i++)
            {
                userMounths.Add(users.FindAll(user => user.CreatedAt.Month == i).Count);
            }

            for (int i = 1; i <= 12; i++)
            {
                campaignMounths.Add(campaigns.FindAll(campaign => campaign.CreatedAt.Month == i).Count);
            }

            for (int i = 1; i <= 12; i++)
            {
                characterMounths.Add(characters.FindAll(character => character.CreatedAt.Month == i).Count);
            }

            for (int i = 1; i <= 12; i++)
            {
                playerMounths.Add(players.FindAll(player => player.CreatedAt.Month == i).Count);
            }

            cartesianData.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Mês",
                Labels = new[] { "Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez" }
            });

            cartesianData.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Geral"
            });

            cartesianData.LegendLocation = LiveCharts.LegendLocation.Right;

            cartesianData.Series.Clear();

            SeriesCollection series = new SeriesCollection();

            series.Add(
                new LineSeries()
                    {
                        Title = "Qtde de usuários",
                        Values = new ChartValues<int>(userMounths)
                    }
                );
            series.Add(
                new LineSeries()
                {
                    Title = "Qtde de Campanhas",
                    Values = new ChartValues<int>(campaignMounths)
                }
            );
            series.Add(
                new LineSeries()
                {
                    Title = "Qtde de Fichas",
                    Values = new ChartValues<int>(characterMounths)
                }
            );
            series.Add(
                new LineSeries()
                {
                    Title = "Qtde de Jogadores",
                    Values = new ChartValues<int>(playerMounths)
                }
            );
            cartesianData.Series = series;
        }
    }
}
