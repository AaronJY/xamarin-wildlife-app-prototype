using Plugin.Media.Abstractions;

namespace Wildlife.Navigation.NavigationModels
{
    public class SpeciesDetailNavigationModel : NavigationModelBase
    {
        public MediaFile MediaFile { get; set; }

        public SpeciesDetailNavigationModel() { }

        public SpeciesDetailNavigationModel(MediaFile mediaFile)
        {
            MediaFile = mediaFile;
        }
    }
}
