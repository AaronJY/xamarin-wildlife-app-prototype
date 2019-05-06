using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wildlife.Navigation;
using Wildlife.Navigation.NavigationModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wildlife.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoCapturePage : ContentPage, IVideoCapturePage
    {
        readonly ISpeciesDetailPage speciesDetailPage;

        public VideoCapturePage(ISpeciesDetailPage speciesDetailPage)
        {
            this.speciesDetailPage = speciesDetailPage;

            InitializeComponent();
            BindEvents();
        }

        void BindEvents()
        {
            videoCaptureButton.Clicked += async (sender, args) =>
            {
                await CrossMedia.Current.Initialize();

                if (!CrossMedia.Current.IsTakeVideoSupported || !CrossMedia.Current.IsCameraAvailable)
                {
                    await DisplayAlert("Oops!", "Sorry, but it looks like your device doesn't support capturing video!", "OK");
                    return;
                }

                var videoStoreOpts = new StoreVideoOptions
                {
                    Name = "myvideo",
                    Directory = "TestVideos"
                };

                using (var file = await CrossMedia.Current.TakeVideoAsync(videoStoreOpts))
                {
                    if (file == null)
                        return;

                    var newPage = (SpeciesDetailPage)speciesDetailPage;
                    newPage.WithValues(new SpeciesDetailNavigationModel(file));

                    await Navigation.PushAsync(newPage);
                }
            };
        }
    }
}