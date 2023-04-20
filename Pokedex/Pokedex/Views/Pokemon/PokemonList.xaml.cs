using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex.ViewModels.VMpokemon;

namespace Pokedex.Views.Pokemon
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PokemonList : ContentPage
    {
        VMpokemonlist vm;
        public PokemonList()
        {
            InitializeComponent();
            vm = new VMpokemonlist(Navigation);
            BindingContext = vm;
            this.Appearing += PokemonList_Appearing;
        }

        private async void PokemonList_Appearing(object sender, EventArgs e)
        {
            await vm.getPokemon();
        }
    }
}