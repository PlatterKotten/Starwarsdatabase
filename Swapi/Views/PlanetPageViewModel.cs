using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
namespace Swapi 
{ 
     public class PlanetPageViewModel 
     {
        public Planet planet { get; set; }
        public string image { get; set; }
        public ObservableCollection<Movie> movies { get; }
        public ObservableCollection<People> people { get; set; }
       
        public PlanetPageViewModel(Planet _planet)
        {
                    planet =_planet;
                    movies = new ObservableCollection<Movie>();
                    people = new ObservableCollection<People>();
                    image= GetImage();
                    GetMovieNames();
                    GetCharacterNames();
        }    
        async void GetMovieNames()
        {
            RestService rst = new RestService();
            foreach (var item in planet.films)
            {
                movies.Add(await rst.GetMovie(item));
            }
        }
        async void GetCharacterNames()
        {
            RestService rst = new RestService();
            foreach (var item in planet.residents)
            {
                people.Add(await rst.GetCharacter(item));
            }
        }
        public string GetImage()
        {
            PictureModel picture = new PictureModel();


            picture.FillWithPictures();
            var url = picture.pictures.Where(c => c.apiURL == planet.url).Select(d => d.apiURL).FirstOrDefault();

            if (url == planet.url)
            {
                return picture.pictures.Where(c => c.apiURL == planet.url).Select(d => d.pictureURL).FirstOrDefault();

            }
            else
            {
                return "Pictures/Characters/noimage.png";
            }
        }

    }
}
