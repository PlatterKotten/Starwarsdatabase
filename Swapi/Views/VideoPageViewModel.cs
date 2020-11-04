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
   
    class VideoPageViewModel
    {
        
        Movie movie;
     
        public VideoPageViewModel(Movie mov) 
        {
            movie = mov;       
        }
        

    }
}
