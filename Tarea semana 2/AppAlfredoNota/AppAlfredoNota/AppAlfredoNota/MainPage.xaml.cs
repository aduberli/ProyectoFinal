using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppAlfredoNota
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            var seguimiento1 = double.Parse(Seguimiento1.Text) * 0.3;
            var examen1 = double.Parse(Examen1.Text) * 0.2;
            var notaParcial1 = seguimiento1 + examen1;
            NotaParcial1.Text = notaParcial1.ToString();

            var seguimiento2 = double.Parse(Seguimiento2.Text) * 0.3;
            var examen2 = double.Parse(Examen2.Text) * 0.2;
            var notaParcial2 = seguimiento2 + examen2;
            NotaParcial2.Text = notaParcial2.ToString();

            var notaFinal = notaParcial1 + notaParcial2;
            NotaFinal.Text = notaFinal.ToString();

        }

        private void BtnLimpiar_Clicked(object sender, EventArgs e)
        {
            Matricula.Text = "";
            Asignatura.Text = "";
            Profesor.Text = "";
            Seguimiento1.Text = "";
            Examen1.Text = "";
            NotaParcial1.Text = "";

            Seguimiento2.Text = "";
            Examen2.Text = "";
            NotaParcial2.Text = "";

            NotaFinal.Text = "";

        }
    }
}
