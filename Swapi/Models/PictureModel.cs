using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Swapi
{
    public class Picture
    {
        public string apiURL { get; set; }
        public string pictureURL { get; set; }
    }
    public class PictureModel
    {
        public List<Picture> pictures { get; set; }

        public PictureModel()
        {


        }
        public void FillWithPictures()
        {
            Picture picture = new Picture();
            pictures = new List<Picture>();

            picture = new Picture();
            pictures.Add(picture);
            picture.apiURL = "http://swapi.dev/api/people/1/";
            picture.pictureURL = "Pictures/Characters/lukeskywalker.jpg";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/people/4/";
            picture.pictureURL = "Pictures/Characters/dartvader.jpg";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/people/13/";
            picture.pictureURL = "Pictures/Characters/chewie.jpeg";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/people/21/";
            picture.pictureURL = "Pictures/Characters/Emperor.png";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/people/25/";
            picture.pictureURL = "Pictures/Characters/Lando.jpg";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/people/5/";
            picture.pictureURL = "Pictures/Characters/leia.jpg";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/people/14/";
            picture.pictureURL = "Pictures/Characters/hansolo.jpg";
            pictures.Add(picture);



            //------------------------PLANETS--------------------------------------

            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/2/";
            picture.pictureURL = "https://static.wikia.nocookie.net/starwars/images/4/4a/Alderaan.jpg/revision/latest?cb=20061211013805";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/1/";
            picture.pictureURL = "https://upload.wikimedia.org/wikipedia/en/6/6d/Tatooine_%28fictional_desert_planet%29.jpg";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/3/";
            picture.pictureURL = "https://static.wikia.nocookie.net/starwars/images/d/d4/Yavin-4-SWCT.png/revision/latest?cb=20181015023938";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/4/";
            picture.pictureURL = "https://upload.wikimedia.org/wikipedia/en/d/d2/Hothplanetsurface.jpg";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/5/";
            picture.pictureURL = "https://static.wikia.nocookie.net/starwars/images/d/d0/Kashyyyk_FFGRebellion.png/revision/latest?cb=20170529040615";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/6/";
            picture.pictureURL = "https://static.wikia.nocookie.net/starwars/images/1/11/Bespin-SWCT.png/revision/latest?cb=20181010054421";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/7/";
            picture.pictureURL = "https://static.wikia.nocookie.net/starwars/images/1/1d/Endor_BF2.png/revision/latest?cb=20171014232605";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/planets/8/";
            picture.pictureURL = "https://vignette.wikia.nocookie.net/swse-resource/images/a/a4/Swse_planet_naboo.png/revision/latest?cb=20180630025013";
            pictures.Add(picture);


            /////////////////////////////starships///////////////////////////////////////
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/starships/12/";
            picture.pictureURL = "https://static.wikia.nocookie.net/starwars/images/d/d4/Xwing.jpg/revision/latest/scale-to-width-down/340?cb=20070118112543&path-prefix=nl";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/starships/10/";
            picture.pictureURL = "https://images.photowall.com/products/42384/star-wars-millennium-falcon-space.jpg?h=699&q=85";
            pictures.Add(picture);
            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/starships/3/";
            picture.pictureURL = "https://sm.mashable.com/t/mashable_sea/news/l/lego-debut/lego-debuts-gigantic-imperial-star-destroyer-model-from-star_cnvs.h720.png";
            pictures.Add(picture);

            /////////////////////////vehicles////////////////////////////////////////////////

            picture = new Picture();
            picture.apiURL = "http://swapi.dev/api/vehicles/18/";
            picture.pictureURL = "https://lh3.googleusercontent.com/proxy/CY26TD_VlsqbYR6folTrppYxbmFR4hlGQWD6g9989hZF9NYwmAXXWHO9I1ToSFpe6zaW3HyrL0xaqJz9jlt8hpQCdQ-I5NWSb0K8UbNRgNIy0XiJ9Vp8gF7DFNwjuvw5qYB-F59bAbWAvEDlUYaYqRqgXRxs-PDAs3gXcBw9y46Jwp-5p-EMDDqh";
            pictures.Add(picture);




        }
    }
}
