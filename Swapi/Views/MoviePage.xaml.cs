using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Net;
using System.Linq;
namespace Swapi
{
    public partial class MoviePage : ContentPage
    {

        MoviePageViewModel viewModel;
        Movie movie;
        public MoviePage(Movie mov)
        {

            BindingContext = viewModel = new MoviePageViewModel(mov);
            this.BackgroundImageSource = "stars.jpg";
            movie = mov;
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

        }
       
        public  void GoToMainPage(object sender, EventArgs e)
        {

           Application.Current.MainPage = new MainPage();

        }
        public async void ClickedCharacter(object sender, EventArgs e)
        {
           
            var myListView = (ContentView)sender; ;
            var selectedMovie = myListView.BindingContext as People;
            People people = new People();
            people = selectedMovie;
         
            await Navigation.PushAsync(new CharacterPage(people));

        }
        public async void ClickedSpecies(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedSpecies = myListView.BindingContext as Species;
            Species species = new Species();
            species = selectedSpecies;
          
            await Navigation.PushAsync(new SpeciesPage(species));
        }
        public async void ClickedPlanet(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender; ;
            var selectedPlanet = myListView.BindingContext as Planet;
            Planet planet = new Planet();
            planet = selectedPlanet;

            await Navigation.PushAsync(new PlanetPage(planet));
        }
        public async void ClickedOnMovie(object sender, EventArgs e)
        {
           
            var myListView = (ContentView)sender;
            var selectedMovie = myListView.BindingContext as Movie;
            Movie mov = new Movie();
            mov = selectedMovie;
           
            await Navigation.PushAsync(new MoviePage(mov));
        }
        public async void ClickedOnStarship(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedStarship = myListView.BindingContext as Starships;
            Starships star = new Starships();
            star = selectedStarship;
          
            await Navigation.PushAsync(new StarshipsPage(star));
        }
        public async void ClickedOnVehicle(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedVehicle = myListView.BindingContext as Vehicles;
            Vehicles vehicle = new Vehicles();
            vehicle = selectedVehicle;
            
            await Navigation.PushAsync(new VehiclesPage(vehicle));
        }
        public async void GoToMoviePage(object sender, EventArgs e)
        {
           
            await Navigation.PushAsync(new VideoPage(movie));
        }
      
    }
}
