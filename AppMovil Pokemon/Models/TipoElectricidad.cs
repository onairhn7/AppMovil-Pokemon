using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class TipoElectricidad : Pokemon
    {
        public void Descarga()
        {
            PuntosAtaque = (int)(PuntosAtaque * 0.02) + PuntosAtaque;
        }
    }
}