using AppMovil_Pokemon.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMovil_Pokemon.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewSeleccion : ContentPage
    {
        public ViewSeleccion()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            this.BindingContext = new ViewModelSeleccion();
        }
    }
}