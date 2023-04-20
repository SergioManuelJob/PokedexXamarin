using System;
using System.Collections.Generic;
using System.Text;
using Pokedex.Models;
using Pokedex.Connection;
using Firebase.Database.Query;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using Firebase.Database;

namespace Pokedex.Data
{
    class Dpokemon
    {
        public async Task InsertPokemon(Mpokemon pokemon)
        {
            List<string> list = new List<string>();
            list.Add("https://i.ibb.co/9wcGfDs/1200px-Growlithe-de-Hisui.png");
            await Cconnection.firebaseClient
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = pokemon.Colorfondo,
                    Colortipo = pokemon.Colortipo,
                    Imagen = pokemon.Imagen,
                    Nombre = pokemon.Nombre,  
                    Nroorden = pokemon.Nroorden,    
                    Tipo = pokemon.Tipo,
                    Forms = list.ToArray()
                }
                );
        }
        public async Task<IEnumerable<Mpokemon>> GetPokemon()
        {
            return (await Cconnection.firebaseClient
                 .Child("Pokemon")
                 .OnceAsync<Mpokemon>())
                 .Select(item => new Mpokemon
                 {
                     Id = item.Key,
                     Nombre = item.Object.Nombre,
                     Nroorden = item.Object.Nroorden,
                     Tipo = item.Object.Tipo,
                     Imagen = item.Object.Imagen,
                     Colorfondo=item.Object.Colorfondo, 
                     Colortipo=item.Object.Colortipo,    
                     Forms = item.Object.Forms
                 });
        }
    }
}
