using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sword_encounter_desktop.Models
{
    public class Campaign
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string MasterId { get; set; }
        public List<CampaignAttribute> Attributes { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
