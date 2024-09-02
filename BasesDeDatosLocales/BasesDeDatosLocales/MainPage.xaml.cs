using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static SQLite.SQLite3;

namespace BasesDeDatosLocales
{
    public class ProductoResponse
    {
        public string _id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public int stockOriginal { get; set; }
        public decimal valor_compra { get; set; }
        public decimal valor_venta { get; set; }
        public string imagen { get; set; }
        public string Categorias__id { get; set; }
        public string Usuarios__id { get; set; }
        public string Usuarios_tipo_id { get; set; }
    }

    public class ResponseData
    {
        public List<List<ProductoResponse>> data { get; set; }
        public ResponseInfo info { get; set; }
    }

    public class ResponseInfo
    {
        public int fieldCount { get; set; }
        public int affectedRows { get; set; }
        public int insertId { get; set; }
        public string info { get; set; }
        public int serverStatus { get; set; }
        public int warningStatus { get; set; }
        public int changedRows { get; set; }
    }

    public class PaginadProductosReq
    {
        public string table { get; set; }
        public string actualPage { get; set; }
        public string size { get; set; }
    }

    public class ProductoPaginado
    {
        public string _id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public int stockOriginal { get; set; }
        public int valor_compra { get; set; }
        public int valor_venta { get; set; }
        public string imagen { get; set; }
        public string Categorias__id { get; set; }
        public string Usuarios__id { get; set; }
        public string Usuarios_tipo_id { get; set; }
    }

    public class ResponsePaginado
    {
        public List<ProductoPaginado> productos { get; set; }
        public Info info { get; set; }
    }

    public class Info
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

    public partial class MainPage : ContentPage
    {
        public string userID { get; set; }
        public string userTipoID { get; set; }
        private ApiService<PaginadProductosReq> productsService = new ApiService<PaginadProductosReq>("/productosapp");
        public ObservableCollection<ProductoPaginado> listaProductos { get; set; }
        public MainPage(string userID, string userTipoID)
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
            this.userID = userID;
            this.userTipoID = userTipoID;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Utiliza await dentro de un método asincrónico OnAppearing
            await cargarImagenes();
        }

        private async Task cargarImagenes()
        {

            PaginadProductosReq request = new PaginadProductosReq();
            request.actualPage = "1";
            request.size = "9";
            request.table = "Productos";

            var response = await productsService.PostResponse(request);

            // Deserializar la lista
            var jsonList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(response);
            List<ProductoPaginado> productList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductoPaginado>>(jsonList[0].ToString());

            string img_1 = productList[0].imagen;
            string img_2 = productList[1].imagen;
            string img_3 = productList[2].imagen;
            string img_4 = productList[3].imagen;
            string img_5 = productList[4].imagen;
            string img_6 = productList[5].imagen;
            string img_7 = productList[6].imagen;
            string img_8 = productList[7].imagen;
            string img_9 = productList[8].imagen;

            // Convertir la lista en una ObservableCollection para el enlace de datos bidireccional
            listaProductos = new ObservableCollection<ProductoPaginado>(productList);

            // Establecer la fuente de datos del ListView
            //miListView.ItemsSource = listaProductos;

            //var hola = "";

        }


        private async void OnProductImageTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductDetailedView(userID, userTipoID));
        }

        private async void OnProductosStackLayoutTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ProductExtendido());
        }



        //MOSTRAR EL CARRUCEL
        private string[] imagenes = { "carrucel1.png", "slider1.jpg" };
        private int indiceActual = 0;
        private void MostrarImagenActual()
        {
            string rutaImagen = imagenes[indiceActual];
            imagenPrincipal2.Source = ImageSource.FromFile(rutaImagen);
        }

        private void SiguienteClick(object sender, EventArgs e)
        {
            indiceActual = (indiceActual + 1) % imagenes.Length;
            MostrarImagenActual();
        }

        private void AnteriorClick(object sender, EventArgs e)
        {
            indiceActual = (indiceActual - 1 + imagenes.Length) % imagenes.Length;
            MostrarImagenActual();
        }

        private async void salir(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
            // DisplayAlert("Alert", "register", "ok");
        }

        private async void IrRutas(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new paginaFotoP());

        }



    }
}
