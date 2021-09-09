using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Actividad8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnMsg1_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Mensaje","Bienvenido al mundo Xamarin.Forms " + txtNombre.Text,"Cancelar");
        }
    }
    }

