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

namespace Pokedex.ViewModels.VMpokemon
{
    public class VMpokemonlist:BaseViewModel
    {
        #region VARIABLES
        ObservableCollection<Mpokemon> _pokemons = new ObservableCollection<Mpokemon>();
        #endregion
        #region CONSTRUCTOR
        public VMpokemonlist(INavigation navigation)
        {
            Navigation = navigation;
            getPokemon();
        }
        #endregion
        #region OBJETOS
        public ObservableCollection<Mpokemon> pokemons
        {
            get { return _pokemons; }
            set { SetValue(ref _pokemons, value);
                OnPropertyChanged();
            }
        }
        #endregion
        #region PROCESOS
        public async Task getPokemon()
        {
            var funcion = new Dpokemon();
            pokemons = await funcion.GetPokemon();
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
