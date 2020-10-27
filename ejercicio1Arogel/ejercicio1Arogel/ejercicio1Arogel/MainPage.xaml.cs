using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ejercicio1Arogel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnAceptar_Clicked(object sender, EventArgs e)
        {
            //Almacenando el contenido de la caja de texto
            String texto = txtNombre.Text;
            //Concatenar cajas de texto
            string mensaje = "hola bienvenido" + texto;
            //Alerta para usuario
            DisplayAlert("mensaje de advertencia", mensaje, "Gracias");

        }
    }
}
