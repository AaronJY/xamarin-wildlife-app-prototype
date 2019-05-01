using System;
using System.Collections.Generic;
using System.Text;

namespace Wildlife.Models
{
    public class SpeciesDetail
    {
        public Guid Id { get;set;}
        
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? LatestSighting { get; set; }
    }
}
