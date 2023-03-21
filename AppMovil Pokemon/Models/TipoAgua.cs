using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class TipoAgua : Pokemon
    {
        public void Evasion()
        {
            PuntosDefensa = (int)(PuntosDefensa * 0.01) + PuntosDefensa;
        }

    }
}