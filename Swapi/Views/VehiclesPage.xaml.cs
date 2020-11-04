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
    public partial class VehiclesPage : ContentPage
    {
        VehiclesPageViewModel viewModel;
        public VehiclesPage(Vehicles vehicles)
        {
            this.BackgroundImageSource = "stars.jpg";
            BindingContext = viewModel = new VehiclesPageViewModel(vehicles);
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
        public void ClickedCharacter(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender; ;
            var selectedMovie = myListView.BindingContext as People;
            People people = new People();
            people = selectedMovie;
            Navigation.PushAsync(new CharacterPage(people));

        }
    }
}