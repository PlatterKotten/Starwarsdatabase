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
    public class VehiclesPageViewModel
    {
        public string image { get; set; }
        public Vehicles vehicles { get; set; }
        public ObservableCollection<Movie> movies { get; }
        public ObservableCollection<People> pilots { get; }
        public VehiclesPageViewModel(Vehicles _vehicles)
        {
            vehicles = _vehicles;
            movies = new ObservableCollection<Movie>();
            pilots = new ObservableCollection<People>();
            GetMovieNames();
            GetPilots();
            image = GetImage();
        }
        async void GetMovieNames()
        {
            RestService rst = new RestService();
            foreach (var item in vehicles.films)
            {
                movies.Add(await rst.GetMovie(item));
            }
        }
        async void GetPilots()
        {
            RestService rst = new RestService();
            foreach (var item in vehicles.pilots)
            {
                pilots.Add(await rst.GetCharacter(item.ToString()));
            }
        }
        public string GetImage()
        {
            PictureModel picture = new PictureModel();
            picture.FillWithPictures();
            var url = picture.pictures.Where(c => c.apiURL == vehicles.url).Select(d => d.apiURL).FirstOrDefault();

            if (url == vehicles.url)
            {
                return picture.pictures.Where(c => c.apiURL == vehicles.url).Select(d => d.pictureURL).FirstOrDefault();

            }
            else
            {
                return "Pictures/Characters/noimage.png";
            }
        }

    }
}