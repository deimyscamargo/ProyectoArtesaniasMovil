using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{
    internal class LoginResponse
    {
        public List<ResponseLogin> Response { get; set; }
        public int FieldCount { get; set; }
        public int AffectedRows { get; set; }
        public int InsertId { get; set; }
        public string Info { get; set; }
        public int ServerStatus { get; set; }
        public int WarningStatus { get; set; }
        public int ChangedRows { get; set; }
    }

    public class ResponseLogin
    {
        public string Rol { get; set; }
        public string UsuarioID { get; set; }

        public string UsuarioTipoID { get; set; }

    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        ApiService<LoginRequest> serviceLogin = new ApiService<LoginRequest>("login");

        public Login()
        {
            InitializeComponent();
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {

            LoginRequest login = new LoginRequest();
            login.user = txtUsuario.Text;
            login.pass = txtPassword.Text;

            var response = await serviceLogin.PostResponse(login);

            // Deserializar la lista
            var jsonList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(response);
            // Deserializar el primer elemento (array) como un List<RolObject>
            var rolObjectList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ResponseLogin>>(jsonList[0].ToString());
            // Acceder a los valores
            string rol = rolObjectList?.Count > 0 ? rolObjectList[0].Rol : "";

            if (rol == "Cliente")
            {
                await Navigation.PushAsync(new MainPage(rolObjectList[0].UsuarioID, rolObjectList[0].UsuarioTipoID));
            }
            else if (rol == "Artesano")
            {
                await Navigation.PushAsync(new CrearArtesania(rolObjectList[0].UsuarioID, rolObjectList[0].UsuarioTipoID));
            }
            else
            {
                await DisplayAlert("Alerta", "No tienes acceso a la aplicación", "OK");
            }

        }


        private async void Noexist1(object sender, EventArgs e)
        {

            await DisplayAlert("Alert!!!", "Esta vista aún no está disponible", "OK?");

        }

        private async void Noexist2(object sender, EventArgs e)
        {

            await DisplayAlert("Alert!!!", "Esta vista aún no está disponible", "OK?");

        }


        private async  void OnRegisterTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage());
           // DisplayAlert("Alert", "register", "ok");
        }
    }
}