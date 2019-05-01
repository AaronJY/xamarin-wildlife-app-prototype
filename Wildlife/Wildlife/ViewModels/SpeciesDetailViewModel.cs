using System;
using System.Collections.Generic;
using System.Text;
using Wildlife.Models;

namespace Wildlife.ViewModels
{
    public class SpeciesDetailViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? LatestSighting { get; set; }

        public string LatestSightingDisplay => LatestSighting == null ? "Never" : $"{LatestSighting:dd-MM-yyyy hh:mm}";

        public SpeciesDetailViewModel()
        {
        }

        public SpeciesDetailViewModel(SpeciesDetail speciesDetail)
        {
            Id = speciesDetail.Id;
            Name = speciesDetail.Name;
            Description = speciesDetail.Description;
            LatestSighting = speciesDetail.LatestSighting;
        }
    }
}
