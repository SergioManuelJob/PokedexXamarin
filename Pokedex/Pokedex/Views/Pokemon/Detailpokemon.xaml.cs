using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Pokedex.ViewModels.VMpokemon;
using Pokedex.Models;

namespace Pokedex.Views.Pokemon
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detailpokemon : ContentPage
	{
		public Detailpokemon (Mpokemon pokemon)
		{
			InitializeComponent ();
			BindingContext = new VMdetallepokemon(Navigation, pokemon);
		}
	}
}