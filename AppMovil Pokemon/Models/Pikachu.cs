using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class Pikachu : TipoElectricidad , I_Correr
    {

      /* public Pikachu()
        {

            Pikachu pikachu1 = new Pikachu()
            {

                Nombre = "Picachu",
                PuntosAtaque = 50,
                PuntosDefensa = 20,
                NivelVida = 300,

            };
            pikachu1.Ataques.Add("Impact trueno");
            pikachu1.Ataques.Add("Attack trueno");

            pikachu1.Descarga();
            pikachu1.Correr();
        } */


       
        public void Correr()
        {
            PuntosAtaque = (int)(PuntosAtaque * 0.03) + PuntosAtaque;
        }

        public override string Evolucion()
        {
            return "Su evolucon es Raichu";
        }

        public ImageSource imagen { get; set; }
       

       
    }
}