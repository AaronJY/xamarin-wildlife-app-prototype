using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wildlife.Services;
using Wildlife.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wildlife.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeciesDetailPage : ContentPage, ISpeciesDetailPage
    {
        Guid _speciesId;

        readonly IWildlifeHttpService _wildlifeHttpService;

        public SpeciesDetailViewModel ViewModel { get; set; }

        public SpeciesDetailPage(
            IWildlifeHttpService wildlifeHttpService)
        {
            _wildlifeHttpService = wildlifeHttpService;

            InitializeComponent();
            BindingContext = ViewModel;

            GetSpecies(Guid.NewGuid());
        }

        public void WithNavigationValues(Guid id)
        {
            _speciesId = id;
        }

        async void GetSpecies(Guid speciesId = default)
        {
            if (speciesId == default)
                throw new ArgumentException($"{nameof(speciesId)} can not be empty");

            var speciesDetail = await _wildlifeHttpService.GetSpeciesById(speciesId);
            if (speciesDetail != null)
            {
                ViewModel = new SpeciesDetailViewModel(speciesDetail);
            }
        }
    }
}