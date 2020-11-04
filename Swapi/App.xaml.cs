using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace Swapi
{
    public partial class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "Expander_Experimental", "Shapes_Experimental"  });

            //"MediaElement_Experimental"



            InitializeComponent();    
            var navigationStyle = new Style(typeof(NavigationPage));
            var barTextColorSetter = new Setter { Property = NavigationPage.BarTextColorProperty, Value = Color.Yellow };
            var barBackgroundColorSetter = new Setter { Property = NavigationPage.BarBackgroundColorProperty, Value = Color.Black };
            navigationStyle.Setters.Add(barTextColorSetter);
            navigationStyle.Setters.Add(barBackgroundColorSetter);
            Current.Resources.Add(navigationStyle);
            ///MainPage = new NavigationPage(new MainPage());
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
