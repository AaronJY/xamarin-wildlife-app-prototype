using System;
using System.Collections.Generic;
using System.Text;
using Wildlife.Models;

namespace Wildlife.ViewModels
{
    public class SpeciesItemViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public SpeciesItemViewModel()
        {
        }

        public SpeciesItemViewModel(Species species)
        {
            Id = species.Id;
            Name = species.Name;
        }
    }
}
