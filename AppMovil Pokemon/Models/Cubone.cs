using System;
using System.Collections.Generic;
using System.Text;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class Cubone : TipoTierra, I_Correr
    {
        public void Correr()
        {
            PuntosAtaque = (int)(PuntosAtaque * 0.03) + PuntosAtaque;
        }

        public override string Evolucion()
        {
            return " Su evolucion es Marowak";
        }

        
    }
}
