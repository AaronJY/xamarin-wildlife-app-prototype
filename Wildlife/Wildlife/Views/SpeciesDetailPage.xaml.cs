using System.Linq;
using Wildlife.Navigation;
using Wildlife.Navigation.NavigationModels;
using Wildlife.Services;
using Wildlife.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wildlife.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeciesDetailPage : ContentPage, ISpeciesDetailPage, INavigableView
    {

        public SpeciesDetailViewModel ViewModel { get; set; }

        SpeciesDetailNavigationModel _navigationModel;

        readonly IWildlifeHttpService _wildlifeHttpService;

        public SpeciesDetailPage(
            IWildlifeHttpService wildlifeHttpService)
        {
            _wildlifeHttpService = wildlifeHttpService;

            BindingContext = ViewModel = new SpeciesDetailViewModel();

            FetchSpeciesList();

            InitializeComponent();
        }

        async void FetchSpeciesList()
        {
            var speciesList = await _wildlifeHttpService.GetListing();
            ViewModel.SpeciesList = speciesList.Select(species => new SpeciesItemViewModel(species));
        }

        public void WithValues(NavigationModelBase model)
        {
            _navigationModel = (SpeciesDetailNavigationModel)model;
        }
    }
}