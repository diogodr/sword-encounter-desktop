using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sword_encounter_desktop.Models
{
    class Character
    {
        public string Id { get; set; }
        public string CampaignId { get; set; }
        public string PlayerId { get; set; }
        public List<CharacterAttribute> Attributes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
