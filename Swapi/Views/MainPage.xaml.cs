using System;
using Xamarin.Forms;

namespace Swapi
{
    public partial class MainPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MainPage()
        {
           
            BindingContext = viewModel = new MainPageViewModel();
            this.BackgroundImageSource = "stars.jpg";
            InitializeComponent();

           
        }
        public void ClickedOnMovie(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedMovie = myListView.BindingContext as Movie;
            Movie mov = new Movie();
            mov = selectedMovie;
            Application.Current.MainPage = new NavigationPage(new MoviePage(mov));
          

        }
    }
}
