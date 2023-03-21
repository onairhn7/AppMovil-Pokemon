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
    public class ViewModelEntrenador : INotifyPropertyChanged
    {

        public ViewModelEntrenador()
        {
            CrearEntrenador = new Command(
                
                () => {

                    Entrenador e = new Entrenador()
                    {

                        nombreEntrenador = this.nombreEntrenador,
                       
                        


                    };

                    
                    ListaEntrenador.Add(e);


                   



                    App.Current.Properties["ListaEntrenador"] = ListaEntrenador;



                });

        }


        string nombreEntrenador;

        public string NombreEntrenador
        {

            get => nombreEntrenador;

            set
            {
                nombreEntrenador = value;
                var arg = new PropertyChangedEventArgs(nameof(NombreEntrenador));

                PropertyChanged?.Invoke(this, arg);
            }
        }

        

        ObservableCollection<Entrenador> listaEntrenador = new ObservableCollection<Entrenador>();

        public ObservableCollection<Entrenador> ListaEntrenador
        {
            get => listaEntrenador;

            set
            {
                listaEntrenador = value;
                var arg = new PropertyChangedEventArgs(nameof(ListaEntrenador));

                PropertyChanged?.Invoke(this, arg);
            }
        }

        string ciudad;

        public string Ciudad
        {

            get => ciudad;
            set
            {

                ciudad = value;
                var arg = new PropertyChangedEventArgs(nameof(Ciudad));
                PropertyChanged?.Invoke(this, arg);

            }

        }

        



        public Command CrearEntrenador { get; }



        public event PropertyChangedEventHandler PropertyChanged;
    }
}