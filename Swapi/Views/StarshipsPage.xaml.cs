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

    public partial class StarshipsPage : ContentPage
    {
        StarshipsPageViewModel viewModel;
        public StarshipsPage(Starships starships)
        {
            BindingContext = viewModel = new StarshipsPageViewModel(starships);
            this.BackgroundImageSource = "stars.jpg";
            InitializeComponent();
        }
        protected override void OnAppearing()
        {

        }
        public  void ClickedOnMovie(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedMovie = myListView.BindingContext as Movie;
            Movie mov = new Movie();
            mov = selectedMovie;
            Application.Current.MainPage = new NavigationPage(new MoviePage(mov));

        }
        public async void ClickedCharacter(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender; ;
            var selectedMovie = myListView.BindingContext as People;
            People people = new People();
            people = selectedMovie;
           await Navigation.PushAsync(new CharacterPage(people));

        }
    }
}