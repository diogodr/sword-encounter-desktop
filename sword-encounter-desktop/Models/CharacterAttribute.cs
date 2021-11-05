﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sword_encounter_desktop.Models
{
    class CharacterAttribute
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
