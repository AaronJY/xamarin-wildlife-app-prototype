using System.Collections.ObjectModel;
using Wildlife.ViewModels;

namespace Wildlife.Views
{
    public interface ISpeciesListPage
    {
        ObservableCollection<SpeciesItemViewModel> Items { get; set; }
    }
}