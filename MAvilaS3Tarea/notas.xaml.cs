using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MAvilaS3Tarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class notas : ContentPage
    {
        public notas()
        {
            InitializeComponent();
        }

        private void btnResultado_Clicked(object sender, EventArgs e)
        {
            //conversion de datos
            double nota1 = Convert.ToDouble(txtNotasg1.Text);
            double notaex_1 = Convert.ToDouble(txtNotaExamen1.Text);


            double notaf_1 = (nota1 + notaex_1) / 4;
            txtNotaParcial1.Text = notaf_1.ToString();
            //segunda operacion


            double nota_2 = Convert.ToDouble(txtNotasg2.Text);
            double notaex_2 = Convert.ToDouble(txtNotaExamen2.Text);

            double notaf2 = (nota_2 + notaex_2) / 4;
            txtNotaParcial2.Text = notaf2.ToString();



            double notafin = (notaf_1 + notaf2);
            txtNotaFinal.Text = notafin.ToString();

            //la accion siempre sera cerra


            if (notafin < 5)
            {
                DisplayAlert("SU CALIFICACION ESTA:", "REPROBADO " + notafin, "Cerrar");
                txtRif.Text = notafin.ToString("REPROBADO: " + notafin);
            }
            if (notafin >= 5 && notafin < 7)
            {
                DisplayAlert("SU CALIFICACION ESTA:", "SUPLETORIO: " + notafin, "Cerrar");
                txtRif.Text = notafin.ToString("SUPLETORIO: " + notafin);

            }
            if (notafin >= 7 && notafin <= 10)
            {
                DisplayAlert("SU CALIFICACION ESTA: ", "APROVADO: " + notafin, "Cerrar");
                txtRif.Text = notafin.ToString("APROVADO: " + notafin);
            }
            if (notafin > 10) { txtRif.Text = notafin.ToString("NOTA FUERA DE RANGO: " + notafin); }

        }

        private void btnlimpiar_Clicked(object sender, EventArgs e)
        {
            txtNotasg1.Text = "";
            txtNotaExamen1.Text = "";
            txtNotaParcial1.Text = "";

            txtNotasg2.Text = "";
            txtNotasg2.Text = "";
            txtNotaExamen2.Text = "";
            txtNotaParcial2.Text = "";

            txtNotaParcial2.Text = "";
            txtNotaFinal.Text = "";
            txtRif.Text = "";

        }
    }
}