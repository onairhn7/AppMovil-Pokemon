using System;
using System.Collections.Generic;
using System.Text;

namespace AppMovil_Pokemon.Models
{
    [Serializable]
    public class Pokemon
    {

        public string Nombre { get; set; }
        public int PuntosAtaque { get; set; }

        public int PuntosDefensa { get; set; }
       


        public List<string> Ataques { get; set; } = new List<string>();

        public double NivelVida { get; set; }





        public double PorcentajeDanio()
        {



            return PuntosAtaque * 0.2;

        }


        public double PorcentajeDefensa()
        {
            return PuntosDefensa * 0.1;

        }



        public virtual string Evolucion()
        {

            return "sobreescribir este metodo";
        }
        public virtual double RecibirAtaque(Pokemon enemigo)


        {
            double danio = enemigo.PorcentajeDanio() - PorcentajeDefensa();
            NivelVida = (NivelVida - danio);

            return NivelVida;

        }

        public override string ToString()
        {
            return $"{Nombre}";
        }
    }
}
