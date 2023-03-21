using System;
using System.Collections.Generic;
using System.Text;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class Charizard : TipoFuego, I_Volar
    {
        public void Volar()
        {

            PuntosDefensa = (int)(PuntosDefensa * 0.05) + PuntosDefensa;



        }

        public override string Evolucion()
        {
            return "Esta en su ultima evolucion";
        }

        
    }
}
