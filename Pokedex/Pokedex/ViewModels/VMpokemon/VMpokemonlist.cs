using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Pokedex.ViewModels.VMpokemon;
using MvvmGuia.VistaModelo;
using Pokedex.Views.Pokemon;
using Pokedex.Data;
using Pokedex.Models;
using System.Collections.ObjectModel;
using System.Collections;
using System.Linq;

namespace Pokedex.ViewModels.VMpokemon
{
    public class VMpokemonlist:BaseViewModel
    {
        #region VARIABLES
        List<Mpokemon> _pokemons = new List<Mpokemon>();
        #endregion
        #region CONSTRUCTOR
        public VMpokemonlist(INavigation navigation)
        {
            Navigation = navigation;
            getPokemon();
        }
        #endregion
        #region OBJETOS
        public List<Mpokemon> pokemons
        {
            get { return _pokemons; }
            set { SetValue(ref _pokemons, value);
            }
        }
        #endregion
        #region PROCESOS
        public async Task getPokemon()
        {
            var funcion = new Dpokemon();
            var pokemonsGet = await funcion.GetPokemon();
            pokemons = pokemonsGet.ToList<Mpokemon>();
            pokemons = pokemons.OrderBy(pokemons => pokemons.Nroorden).ToList();
        }
        public async Task goToRegister()
        {
            await Navigation.PushAsync(new CreatePokemon());
        }
        public async Task GoToDetail(Mpokemon pokemon)
        {
            await Navigation.PushAsync(new Detailpokemon(pokemon));
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand goToRegistercommand => new Command(async () => await goToRegister());
        public ICommand goToDetailcommand => new Command<Mpokemon>(async (p) => await GoToDetail(p));
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
