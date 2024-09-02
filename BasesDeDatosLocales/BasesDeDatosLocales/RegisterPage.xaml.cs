using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        //PASO APISERVICES
        ApiService<Usuario> service = new ApiService<Usuario>("users");
        private string tipoIdUser;

        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void Atras(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
            // DisplayAlert("Alert", "register", "ok");
        }

        private async void Siguiente(object sender, EventArgs e)
        {

            this.tipoIdUser = tipo_id.SelectedItem as string;

            // Suponiendo que tienes el nombre completo en un solo campo
            string nombreCompleto = primer_nombre.Text;

            // Dividir el nombre completo en partes usando el espacio como separador
            string[] partesNombre = nombreCompleto.Split(' ');

            // Asignar partes del nombre a las variables correspondientes
            string primerNombre = partesNombre[0];
            string segundoNombre = partesNombre.Length > 1 ? partesNombre[1] : string.Empty;
            string primerApellido = partesNombre.Length > 2 ? partesNombre[2] : string.Empty;
            string segundoApellido = partesNombre.Length > 3 ? partesNombre[3] : string.Empty;

            Usuario usuario = new Usuario(
                _id.Text,
                this.tipoIdUser,
                primerNombre,
                segundoNombre,
                primerApellido,
                segundoApellido,
                fecha_nacimiento.Text,
                telefono.Text,
                direccion.Text,
                correo.Text
            );


            Limpiar();
            await Navigation.PushAsync(new register2(usuario));

        }
        private void Limpiar()

        {
            _id.Text = "";
            fecha_nacimiento.Text ="";
            telefono.Text = "";
            direccion.Text = "";
            correo.Text = "";
        }

    }
}