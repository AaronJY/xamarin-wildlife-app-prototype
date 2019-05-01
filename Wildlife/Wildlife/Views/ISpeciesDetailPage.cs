using System;
using Wildlife.ViewModels;

namespace Wildlife.Views
{
    public interface ISpeciesDetailPage
    {
        SpeciesDetailViewModel ViewModel { get; set; }
        void WithNavigationValues(Guid id);
    }
}