using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace Pokedex.Connection
{
    public class Cconnection
    {
        public static FirebaseClient firebaseClient = new FirebaseClient("https://pokedexxamarin-741c2-default-rtdb.firebaseio.com/");
    }
}
