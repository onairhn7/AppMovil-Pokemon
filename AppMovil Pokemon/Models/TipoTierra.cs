using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class TipoTierra : Pokemon
    {
        public void AumentarDureza()
        {

            PuntosDefensa = (int)(PuntosDefensa * 0.02) + PuntosDefensa;
        }
    }
}