using MvvmGuia.VistaModelo;
using Pokedex.Data;
using Pokedex.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Pokedex.ViewModels.VMpokemon
{
    class VMdetallepokemon : BaseViewModel
    {
        #region VARIABLES
        public Mpokemon mpokemon { get; set; }
        public string fondo { get; set; }
        public string tipo { get; set; }        
        #endregion
        #region CONSTRUCTOR
        public VMdetallepokemon(INavigation navigation, Mpokemon pokemon)
        {
            Navigation = navigation;
            mpokemon = pokemon;
            if(mpokemon.Forms == null)
            {
                List<string> list = new List<string>();
                list.Add("https://i.ibb.co/3134kkG/5a4613ddd099a2ad03f9c994.png");
                mpokemon.Forms = list.ToArray();
            }
        }
        #endregion
        #region OBJETOS

        #endregion
        #region PROCESOS

        public async Task goBack()
        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand goBackcommand => new Command(async () => await goBack());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
