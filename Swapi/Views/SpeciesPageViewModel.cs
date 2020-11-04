using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Linq;
namespace Swapi
{
   
    public class SpeciesPageViewModel :INotifyPropertyChanged
    {
        private string homeworld = string.Empty;

        public event PropertyChangedEventHandler PropertyChanged;

        public string HomeWorld
        {
            get { return homeworld; }
            set
            {
                if (homeworld == value)
                    return;
                homeworld = value;             
                OnPropertyChanged(nameof(HomeWorld));
                OnPropertyChanged(nameof(HomePlanet));// Notify that there was a change on this property
            }
        }

        public Planet planet { get; set; } 
        public string HomePlanet => $"{HomeWorld}";
        public string image { get; set; }
        public ICommand gotohomeworld { get; set; }
        public INavigation Navigation { get; set; }
        public Species species { get; set; }
        public ObservableCollection<Movie> movies { get; }
        public ObservableCollection<People> people { get; set; }
        public SpeciesPageViewModel(Species _species)
        {
            species = _species;
            if (species.homeworld == null)
                species.homeworld = "http://swapi.dev/api/planets/";
            gotohomeworld = new Command(GotoHomeWorld);
            movies = new ObservableCollection<Movie>();
            people = new ObservableCollection<People>(); 
            GetMovieNames();
            GetCharacterNames();
            GetHomeWorld();
            image = GetImage();
        }
        void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        async void GetMovieNames()
        {
            RestService rst = new RestService();
            foreach (var item in species.films)
            {
                movies.Add(await rst.GetMovie(item));
            }
        }
        async void GetCharacterNames()
        {
            RestService rst = new RestService();
            foreach (var item in species.people)
            {
                people.Add(await rst.GetCharacter(item));
            }
        }
        public async void GetHomeWorld()
        {
            RestService rst = new RestService();
            planet = await rst.GetPlanets(species.homeworld);        
            HomeWorld = planet.name;

        }
        void GotoHomeWorld()
        {
            Navigation.PushAsync(new PlanetPage(planet));
        }
        public string GetImage()
        {
            PictureModel picture = new PictureModel();


            picture.FillWithPictures();
            var url = picture.pictures.Where(c => c.apiURL == species.url).Select(d => d.apiURL).FirstOrDefault();

            if (url == species.url)
            {
                return picture.pictures.Where(c => c.apiURL == species.url).Select(d => d.pictureURL).FirstOrDefault();
            }
            else
            {
                return "Pictures/Characters/noimage.png";
            }
        }
    }

}






