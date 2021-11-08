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
    public class UserClient
    {
        private static HttpClient client = new HttpClient();
        public async Task<List<User>> ListUsers()
        {
            List<User> users = null;
            var response = await client.GetAsync("https://localhost:44359/api/Users");
            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            users = JsonConvert.DeserializeObject<User[]>(jsonString.Result).ToList();            
            return users;
        }
    }
}
