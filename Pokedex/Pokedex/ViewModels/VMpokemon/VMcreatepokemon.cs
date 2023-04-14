using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MvvmGuia.VistaModelo;

namespace Pokedex.ViewModels.VMpokemon
{
    public class VMcreatepokemon:BaseViewModel
    {
        #region VARIABLES
        string _Txtname;
        string _Txtnumber;
        string _Txtbgcolor;
        string _Txttypecolor;
        string _Txtype;
        string _Txtimage;
        #endregion
        #region CONSTRUCTOR
        public VMcreatepokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Txtname
        {
            get { return _Txtname; }
            set { SetValue(ref _Txtname, value); }
        }
        public string Txtnumber
        {
            get { return _Txtnumber; }
            set { SetValue(ref _Txtnumber, value); }
        }
        public string Txtbgcolor
        {
            get { return _Txtbgcolor; }
            set { SetValue(ref _Txtbgcolor, value); }
        }
        public string Txttypecolor
        {
            get { return _Txttypecolor; }
            set { SetValue(ref _Txttypecolor, value); }
        }
        public string Txttype
        {
            get { return _Txtype; }
            set { SetValue(ref _Txtype, value); }
        }
        public string Txtimage
        {
            get { return _Txtimage; }
            set { SetValue(ref _Txtimage, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region COMANDOS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
