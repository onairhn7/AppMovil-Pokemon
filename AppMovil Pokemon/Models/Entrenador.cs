using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class Entrenador : ContentPage
    {
       public string nombreEntrenador { get; set; }
       public string ciudad { get; set; }

       public List<Pokemon> pokemones { get; set; } = new List<Pokemon>();


        public List<Pokemon> pokemonesEnemigos { get; set; } = new List<Pokemon>();


        public override string ToString()
        {
            return $"{nombreEntrenador}";
        }


    }


    
}