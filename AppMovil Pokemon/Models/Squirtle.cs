using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class Squirtle : TipoAgua, I_Nadar
    {
        public void Nadar()
        {

            PuntosDefensa = (int)(PuntosDefensa * 0.03) + PuntosDefensa;
        }

        public override string Evolucion()
        {
            return "Su siguinete evolucion es Wartortle";
        }

        
    }
}