using Newtonsoft.Json;
using sword_encounter_desktop.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace sword_encounter_desktop.Client
{
    public class CampaignClient
    {
        private static HttpClient client = new HttpClient();
        public async Task<List<Campaign>> ListCampaigns()
        {
            List<Campaign> campaigns = null;
            var response = await client.GetAsync("https://localhost:44359/api/Campaigns");
            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            campaigns = JsonConvert.DeserializeObject<Campaign[]>(jsonString.Result).ToList();
            return campaigns;
        }
    }
}
