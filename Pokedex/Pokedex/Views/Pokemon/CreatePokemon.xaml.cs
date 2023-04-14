﻿using System;
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
    public partial class CreatePokemon : ContentPage
    {
        public CreatePokemon()
        {
            InitializeComponent();
            BindingContext = new VMcreatepokemon(Navigation);
        }
    }
}