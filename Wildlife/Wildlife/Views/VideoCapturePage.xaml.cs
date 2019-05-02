using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wildlife.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoCapturePage : ContentPage, IVideoCapturePage
    {
        public VideoCapturePage()
        {
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

                    await DisplayAlert("Success", "You have successfully taken a video of your species!", "OK");
                }
            };
        }
    }
}