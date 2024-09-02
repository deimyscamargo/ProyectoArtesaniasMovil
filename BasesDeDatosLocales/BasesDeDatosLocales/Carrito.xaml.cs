using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{
    public class CarritoResponse
    {
        public List<CarritoItem> Carrito { get; set; }
        public ServerStatusInfo ServerStatusInfo { get; set; }
    }

    public class CarritoItem
    {
        public int CarritoID { get; set; }
        public string UsuarioID { get; set; }
        public string UsuarioTipoID { get; set; }
        public string ProductoID { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioVenta { get; set; }
        public string RutaImagen { get; set; }
    }

    public class ServerStatusInfo
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
    public partial class Carrito : ContentPage
    {
        public string userID { get; set; }
        public string userTipoID { get; set; }
        public Carrito(string userID, string userTipoID)
        {
            InitializeComponent();
            this.userID = userID;
            this.userTipoID = userTipoID;
        }
        public Carrito()
        {
            InitializeComponent();
        }

        private async void Pagar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Factura(userID, userTipoID));
            // DisplayAlert("Alert", "register", "ok");
        }

        private async void Noexist2(object sender, EventArgs e)
        {

            await DisplayAlert("Alert!!!", "Esta vista aún no está disponible", "OK?");

        }

    }
}