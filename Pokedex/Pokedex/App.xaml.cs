
using Pokedex.Views;
using Pokedex.Views.Pokemon;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pokedex
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new PokemonList());
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
