using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class TipoFuego : Pokemon
    {
        public void Enojarse()
        {

            PuntosAtaque = (int)(PuntosAtaque * 0.05) + PuntosAtaque;
        }
    }
}