using System;
using System.Collections.Generic;

namespace ToonEfMvc.Models.Toons
{
    public partial class Organisms
    {
        public int OrganismId { get; set; }
        public string Name { get; set; }
        public string SpecieName { get; set; }

        public virtual Species SpecieNameNavigation { get; set; }
    }
}
