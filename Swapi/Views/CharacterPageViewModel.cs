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
    public class CharacterPageViewModel : INotifyPropertyChanged
    {
        public People people { get; set; }
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
                OnPropertyChanged(nameof(HomePlanet));
               
            }
        }
      
        public string image { get; set; }
        public Planet planet { get; set; }
        public string HomePlanet => $"{HomeWorld}";
        public ObservableCollection<Starships> starships { get; set; }
        public ObservableCollection<Movie> movies { get; }
        public ObservableCollection<Vehicles> vehicles { get; set; }
        public ICommand gotohomeworld { get; set; }
        public INavigation Navigation { get; set; }
       public CharacterPageViewModel(People _people)
        {
            people = _people;
            gotohomeworld = new Command(GotoHomeWorld);
            movies = new ObservableCollection<Movie>();
            vehicles = new ObservableCollection<Vehicles>();
            starships = new ObservableCollection<Starships>();
            
            image = GetImage();
            GetVehicleNames();
            GetMovieNames();
            GetStarshipNames();
           
        }
       
        void OnPropertyChanged(string name) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        async void GetStarshipNames()
        {
           
            RestService rst = new RestService();
            foreach (var item in people.starships)
            {
                starships.Add(await rst.GetStarships(item));
               
            }           
            
        }
        async void GetVehicleNames()
        {
            RestService rst = new RestService();
            foreach (var item in people.vehicles)
            {
                vehicles.Add(await rst.GetVehicles(item));
            }
        }
        async void GetMovieNames()
        {
            RestService rst = new RestService();
            foreach (var item in people.films)
            {
                movies.Add(await rst.GetMovie(item));
            }
        }
       public async void GetHomeWorld()
        {
               RestService rst = new RestService();
                planet = await rst.GetPlanets(people.homeworld);
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
            var url = picture.pictures.Where(c => c.apiURL == people.url).Select(d => d.apiURL).FirstOrDefault();
          
            if (url== people.url) 
            {
                return picture.pictures.Where(c => c.apiURL == people.url).Select(d => d.pictureURL).FirstOrDefault();

            }
            else 
            {
                RestService rst = new RestService();
                
                return "Pictures/Characters/noimage.png";
            }

        }
        
    }
}
