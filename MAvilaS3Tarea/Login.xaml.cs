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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            string usuario =txtUser.Text;
            string pass=txtPass.Text;
            if(usuario=="estudiante2023"&& pass == "uisrael2023")
            {
                Navigation.PushAsync(new notas());
            }
            else
            {
                DisplayAlert("ALERTA","usuario y contraseña incorrectos","CERRAR");
                txtUser.Text = "";
                txtPass.Text = "";
            }

        }

        private void btnRgistrar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new registro());
        }
    }
}