using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Swapi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CharacterPage : ContentPage
    {
        
        CharacterPageViewModel viewModel;
        public CharacterPage(People people)
        {
           
            BindingContext = viewModel = new CharacterPageViewModel(people);
            viewModel.Navigation = Navigation;
            
            this.BackgroundImageSource = "stars.jpg";
           
           
            InitializeComponent();
           

        }
        protected  override void OnAppearing()
        {
             ((CharacterPageViewModel)BindingContext).GetHomeWorld();

        }
        public  void ClickedOnMovie(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedMovie = myListView.BindingContext as Movie;
            Movie mov = new Movie();
            mov = selectedMovie;
            Application.Current.MainPage = new NavigationPage(new MoviePage(mov));

        }
        public void ClickedOnVehicle(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedVehicle = myListView.BindingContext as Vehicles;
            Vehicles vehicle = new Vehicles();
            vehicle = selectedVehicle;
            Navigation.PushAsync(new VehiclesPage(vehicle));

        }
        public async void ClickedOnStarship(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedStarship = myListView.BindingContext as Starships;
            Starships star = new Starships();
            star = selectedStarship;
     
            await Navigation.PushAsync(new StarshipsPage(star));
        }
       
    }
}