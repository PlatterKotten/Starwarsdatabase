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
    public partial class SpeciesPage : ContentPage
    {
        SpeciesPageViewModel viewModel;
        public SpeciesPage(Species species)
        {
            BindingContext = viewModel = new SpeciesPageViewModel(species);
            this.BackgroundImageSource = "stars.jpg";
            viewModel.Navigation = Navigation;
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
        public async void ClickedCharacter(object sender, EventArgs e)
        {
            var myListView = (ContentView)sender;
            var selectedCharacter = myListView.BindingContext as People;
            People people = new People();
            people = selectedCharacter;
           await Navigation.PushAsync(new CharacterPage(people));

        }
    }
}