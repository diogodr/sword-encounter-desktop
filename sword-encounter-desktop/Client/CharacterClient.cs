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
    class CharacterClient
    {
        private static HttpClient client = new HttpClient();
        public async Task<List<Character>> ListCharacters()
        {
            List<Character> characters = null;
            var response = await client.GetAsync("https://localhost:44359/api/Characters");
            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            characters = JsonConvert.DeserializeObject<Character[]>(jsonString.Result).ToList();
            return characters;
        }

        public async Task<List<Character>> ListPlayers()
        {
            List<Character> characters = null;
            var response = await client.GetAsync("https://localhost:44359/api/Characters");
            var jsonString = response.Content.ReadAsStringAsync();
            jsonString.Wait();
            characters = JsonConvert.DeserializeObject<Character[]>(jsonString.Result).ToList();

            var players = characters.FindAll(character => character.PlayerId != null);

            return players;
        }
    }
}
