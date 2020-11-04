
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Linq;
using Newtonsoft.Json.Linq;
using System.Web;
using System.Net;
using System.ComponentModel;
namespace Swapi
{
    public class MoviePageViewModel
    {
       
        public Movie movie { get; set; }
        public string image { get; set; }
        public ObservableCollection<Species> species { get; set; }
        public ObservableCollection<Starships> starships { get; set; }
        public ObservableCollection<People> people { get; set; }
        public ObservableCollection<Planet> planets { get; set; }
        public ObservableCollection<Vehicles> vehicles { get; set; }
        
       
        public ICommand goToMainPage { get; set; }

      
        public MoviePageViewModel(Movie _movie)
        {
            
            movie = _movie;
           
            goToMainPage = new Command(GoToMainPage);
            species = new ObservableCollection<Species>();
            vehicles = new ObservableCollection<Vehicles>();
            starships = new ObservableCollection<Starships>();
            planets = new ObservableCollection<Planet>();
            people = new ObservableCollection<People>();
          
            image = GetImage();
            GetCharacterNames();
            GetPlanetNames();
            GetStarshipNames();
            GetVehicleNames();
            GetSpeciesNames();
          

        }
       
       
         async void GetCharacterNames() 
        {
            RestService rst = new RestService();
            foreach (var item in movie.characters)
            {
                 people.Add( await rst.GetCharacter(item));
            }
        }
        async void GetPlanetNames()
        {
            RestService rst = new RestService();
            foreach (var item in movie.planets)
            {
                planets.Add(await rst.GetPlanets(item));
            }
        }
        async void GetStarshipNames()
        {
            RestService rst = new RestService();
            foreach (var item in movie.starships)
            {
                starships.Add(await rst.GetStarships(item));
            }
        }
        async void GetVehicleNames()
        {
            RestService rst = new RestService();
            foreach (var item in movie.vehicles)
            {
                vehicles.Add(await rst.GetVehicles(item));
            }
        }
        async void GetSpeciesNames()
        {
            RestService rst = new RestService();
            foreach (var item in movie.species)
            {
                species.Add(await rst.GetSpecies(item));
            }
        }
        public string GetImage() 
        {
            List<string> imagelist = new List<string>() {"", "Pictures/Movies/thephantommenace.jpg", "Pictures/Movies/attackoftheclones.jpg", "Pictures/Movies/revengeofthesith.jpg", "Pictures/Movies/anewhope.jpg" , "Pictures/Movies/empirestrikesback.jpg", "Pictures/Movies/returnofthejedi.jpg", "", "", "", "", "", "", };
            return imagelist[movie.episode_id];
        }
        
        public  void GoToMainPage()
        {
            
           Application.Current.MainPage = new MainPage();

          
        }
       

       
    }
}
    
      

