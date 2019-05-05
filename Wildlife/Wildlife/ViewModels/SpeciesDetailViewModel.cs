using System;
using System.Collections.Generic;
using System.Text;
using Wildlife.Models;

namespace Wildlife.ViewModels
{
    public class SpeciesDetailViewModel
    {
        public IEnumerable<SpeciesItemViewModel> SpeciesList { get; set; }

        public SpeciesItemViewModel SelectedSpecies { get; set; }

        public SpeciesDetailViewModel()
        {
        }
    }
}
