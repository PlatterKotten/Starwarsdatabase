using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swapi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VideoPage : ContentPage
    {
        
        VideoPageViewModel viewModel;
        Movie movie;
        
        public VideoPage(Movie mov)

        {         
            movie = mov;
            BindingContext = viewModel = new VideoPageViewModel(mov);
            InitializeComponent();     
            this.BackgroundImageSource = "stars.jpg";
        }
       
        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();
        //}

    }
}