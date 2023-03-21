using AppMovil_Pokemon.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

using Xamarin.Forms;

namespace AppMovil_Pokemon.ViewModels
{
    public class ViewModelSeleccion : INotifyPropertyChanged
    {


        public ViewModelSeleccion()
        {



            


                       try
                       {
                //Esto se repite por eso lo quite 
                /* pokes = App.Current.Properties["ListaPokemones"] as ObservableCollection<Pokemon>; */
                listaEntrenador = App.Current.Properties["ListaEntrenador"] as ObservableCollection<Entrenador>;
               

            }
            catch (Exception ex)
            {


            }

            
            


            AsignarPokemon = new Command(() => {

                entrenadorSeleccionado.pokemones.Add(pokemonSeleccionado);
                entrenadorEnemigo.pokemonesEnemigos.Add(pokemonEnemigo);
               
                
                int i = 0;
                i = i + 1;

            });


           

              Pikachu pikachu1 = new Pikachu()
              {

                  Nombre = "Picachu",
                  PuntosAtaque = 50,
                  PuntosDefensa = 20,
                  NivelVida = 300,



              };

              pokes.Add(pikachu1);
            pokesEnemigos.Add(pikachu1);
              pikachu1.Ataques.Add("Impact trueno");
              pikachu1.Ataques.Add("Attack trueno");
            

              Squirtle squirtle1 = new Squirtle()
              {
                  Nombre = "Squirtle",
                  PuntosAtaque = 45,
                  PuntosDefensa = 30,
                  NivelVida = 300

              };

              pokes.Add(squirtle1);
            pokesEnemigos.Add(squirtle1);

              Cubone Cubone1 = new Cubone
              {
                  Nombre = "Cubone",
                  PuntosAtaque = 55,
                  PuntosDefensa = 30,
                  NivelVida = 320
              };

              pokes.Add(Cubone1);
            pokesEnemigos.Add(Cubone1);

              Charizard Charizard1 = new Charizard
              {

                  Nombre = "Charizard",
                  PuntosAtaque = 90,
                  PuntosDefensa = 40,
                  NivelVida = 400


              };

            

              pokes.Add(Charizard1);
            pokesEnemigos.Add(Charizard1);

           


                mensaje = pikachu1.RecibirAtaque(Charizard1);

            App.Current.Properties["ListaPokemones"] = pokes;
            App.Current.Properties["ListaEnemigos"] = pokesEnemigos;



        }



        Entrenador entrenadorEnemigo = new Entrenador();
        public Entrenador EntrenadorEnemigo
        {
            get => entrenadorEnemigo;
            set
            {

                entrenadorSeleccionado = value;
                var arg = new PropertyChangedEventArgs(nameof(EntrenadorEnemigo));
                PropertyChanged?.Invoke(this, arg);

            }

        }

        double mensaje;

        public double Mensaje
        {

            get => mensaje;
            set
            {

                mensaje = value;
                var arg = new PropertyChangedEventArgs(nameof(Mensaje));
                PropertyChanged?.Invoke(this, arg);

            }

        }



        Entrenador entrenadorSeleccionado = new Entrenador();
        public Entrenador EntrenadorSeleccionado
        {
            get => entrenadorSeleccionado;
            set
            {

                entrenadorSeleccionado = value;
                var arg = new PropertyChangedEventArgs(nameof(EntrenadorSeleccionado));
                PropertyChanged?.Invoke(this, arg);

            }

        }


        Pokemon pokemonEnemigo = new Pokemon();
        public Pokemon PokemonEnemigo
        {
            get => pokemonEnemigo;
            set
            {

                pokemonSeleccionado = value;
                var arg = new PropertyChangedEventArgs(nameof(PokemonEnemigo));
                PropertyChanged?.Invoke(this, arg);

            }

        }


        Pokemon pokemonSeleccionado = new Pokemon();
        public Pokemon PokemonSeleccionado
        {
            get => pokemonSeleccionado;
            set
            {

                pokemonSeleccionado = value;
                var arg = new PropertyChangedEventArgs(nameof(PokemonSeleccionado));
                PropertyChanged?.Invoke(this, arg);

            }

        }





        public ObservableCollection<Pokemon> pokesEnemigos { get; set; } = new ObservableCollection<Pokemon>();

        public ObservableCollection<Pokemon> pokes { get; set; } = new ObservableCollection<Pokemon>();
        public ObservableCollection<Entrenador> listaEntrenador { get; set; } = new ObservableCollection<Entrenador>();


        public Command CrearPelea { get; }

        public Command AsignarPokemon { get; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}