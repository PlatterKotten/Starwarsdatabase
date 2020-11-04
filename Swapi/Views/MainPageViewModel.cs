using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Swapi
{
    public class MainPageViewModel
    {
        public ObservableCollection<Movie> movies { get; }
        public MainPageViewModel()
        {

            GetMovies();
            movies = new ObservableCollection<Movie>();
        }

        async void  GetMovies()
        {

            RestService rst = new RestService();
            foreach (var item in await rst.GetMovies(Constants.swApiURL))
            {

                movies.Add(item);
            }
        }










    }
}
