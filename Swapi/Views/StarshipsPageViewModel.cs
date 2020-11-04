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
    public class StarshipsPageViewModel
    {
        public string image { get; set; }
        public Starships starships { get; set; }
        public ObservableCollection<Movie> movies { get; }
        public ObservableCollection<People> pilots { get; }
        public StarshipsPageViewModel(Starships _starships) 
        {
            starships = _starships;
            movies = new ObservableCollection<Movie>();
            pilots = new ObservableCollection<People>();
            GetMovieNames();
            GetPilots();
            image= GetImage();
        }
        async void GetMovieNames()
        {
            RestService rst = new RestService();
            foreach (var item in starships.films)
            {
                movies.Add(await rst.GetMovie(item));
            }
        }
        async void GetPilots()
        {
            RestService rst = new RestService();
            foreach (var item in starships.pilots)
            {
                pilots.Add(await rst.GetCharacter(item.ToString()));
            }
        }
        public string GetImage()
        {
            PictureModel picture = new PictureModel();
            picture.FillWithPictures();
            var url = picture.pictures.Where(c => c.apiURL == starships.url).Select(d => d.apiURL).FirstOrDefault();

            if (url == starships.url)
            {
                return picture.pictures.Where(c => c.apiURL == starships.url).Select(d => d.pictureURL).FirstOrDefault();
            }
            else
            {
                return "Pictures/Characters/noimage.png";
            }
        }
    }
}
