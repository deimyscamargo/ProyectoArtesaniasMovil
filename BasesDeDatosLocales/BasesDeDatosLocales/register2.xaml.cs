using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{

    public class RegistroResponse
    {
        public List<List<ResultadoItem>> Resultado { get; set; }
        public InformacionAdicional InformacionAdicional { get; set; }
    }

    public class ResultadoItem
    {
        public string Resultado { get; set; }
    }

    public class InformacionAdicional
    {
        public int fieldCount { get; set; }
        public int affectedRows { get; set; }
        public int insertId { get; set; }
        public string info { get; set; }
        public int serverStatus { get; set; }
        public int warningStatus { get; set; }
        public int changedRows { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class register2 : ContentPage
	{
       // ApiService<Roles> serviceRoles = new ApiService<Roles>("roles");
       // ApiService<Credenciales> serviceCredenciales = new ApiService<Credenciales>("credenciales");

        //PRIMER PASO
        ApiService<RegisterRequest> serviceRegister = new ApiService<RegisterRequest>("registeruser");

        private Usuario usuarioIN;

        //tambien
        public register2(Usuario usuarioIN)
		{
			InitializeComponent ();
            this.usuarioIN = usuarioIN;
        }

        private async void Atras(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
            // DisplayAlert("Alert", "register", "ok");
        }


        //AQUI VA LO DE SEBAS
        private async void Registrar(object sender, EventArgs e)
        {

            //desde aqui
            RegisterRequest registerRequest = new RegisterRequest();
            registerRequest.p_id = usuarioIN._id;
            registerRequest.p_tipo_id = usuarioIN.tipo_id;
            registerRequest.p_primer_nombre = usuarioIN.primer_nombre;
            registerRequest.p_segundo_nombre = usuarioIN.segundo_nombre;
            registerRequest.p_primer_apellido = usuarioIN.primer_apellido;
            registerRequest.p_segundo_nombre = usuarioIN.segundo_nombre;
            registerRequest.p_fecha_nacimiento = usuarioIN.fecha_nacimiento;
            registerRequest.p_telefono = usuarioIN.telefono;
            registerRequest.p_direccion = usuarioIN.direccion;
            registerRequest.p_correo = usuarioIN.correo;
            registerRequest.p_tipo_rol = tipo.SelectedItem as string;
            registerRequest.p_usuario = usuario.Text;
            registerRequest.p_contrasena = contrasena.Text;


            var response = await serviceRegister.PostResponse(registerRequest);

            // Deserializar la lista
            var jsonList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(response);
            // Deserializar el primer elemento (array) como un List<RolObject>
            var resulitObjectList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ResultadoItem>>(jsonList[0].ToString());
            // Acceder a los valores
            string res = resulitObjectList?.Count > 0 ? resulitObjectList[0].Resultado : "";
            

            if(res == "Usuario creado con éxito.")
            {
                await DisplayAlert("Mensaje", "Usuario creado con exito", "Ok");
            }
            else
            {
                await DisplayAlert("Mensaje", "Usuario no creado", "Ok");

            }

        }

    }
}