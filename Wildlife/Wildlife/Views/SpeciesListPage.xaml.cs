using Autofac;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Wildlife.Services;
using Wildlife.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wildlife.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SpeciesListPage : ContentPage, ISpeciesListPage
    {
        readonly IWildlifeHttpService _wildlifeHttpService;
        readonly ISpeciesDetailPage _speciesDetailPage;

        public ObservableCollection<SpeciesItemViewModel> Items { get; set; }

        public SpeciesListPage(
            IWildlifeHttpService wildlifeHttpService,
            ISpeciesDetailPage speciesDetailPage)
        {
            _wildlifeHttpService = wildlifeHttpService;
            _speciesDetailPage = speciesDetailPage;

            InitializeComponent();

            GetListing();
        }

        async void GetListing()
        {
            var entries = await _wildlifeHttpService.GetListing();
            Items = new ObservableCollection<SpeciesItemViewModel>(entries.Select(x => new SpeciesItemViewModel(x)));
            SpeciesListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            _speciesDetailPage.WithNavigationValues(Guid.NewGuid());
            await Navigation.PushAsync((ContentPage)_speciesDetailPage);

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
