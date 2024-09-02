using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace BasesDeDatosLocales
{


    public class FacturaResponse
    {
        public string result { get; set; }
    }

    public class Medio
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        
        public Medio(string Tipo, string Nombre)
        {
            this.Tipo = Tipo;
            this.Nombre = Nombre;
        }

    }


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Factura : ContentPage
    {
        // ApiService<MetodoPagoCompra> service = new ApiService<MetodoPagoCompra>("MetodoPago");
        //ApiService<Factura> serviceFacture = new ApiService<Factura>("factura");

        ApiService<FacturaRequest> serviceFactura = new ApiService<FacturaRequest>("procesocompras");

        private string UsuariosId;
        private string UsuariosTipoId;
        private List<Medio> mediosList = new List<Medio>();

        public Factura(string userID, string userTipoID)
        {
            InitializeComponent();
            this.UsuariosId = userID;
            this.UsuariosTipoId = userTipoID;
        }

        public Factura()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            mediosList.Add(new Medio("TDebito", "Tarjeta debito"));
            mediosList.Add(new Medio("TCredito", "Tarjeta credito"));
            mediosList.Add(new Medio("Efectivo", "Efectivo"));
            mediosList.Add(new Medio("Transferencia", "Transferencia"));

            List<string> nombresCategorias = new List<string>();

            foreach (var medio in mediosList)
            {
                nombresCategorias.Add(medio.Nombre); // Agregar solo el nombre para el Picker
            }

            TipoCuenta.ItemsSource = nombresCategorias; // Asignar los nombres al Picker;

        }

        private async void Pagar(object sender, EventArgs e)
        {

            string nombreTipoSeleccionadp = TipoCuenta.SelectedItem as string;
            Medio categoriaSeleccionada = mediosList.FirstOrDefault(c => c.Nombre == nombreTipoSeleccionadp);

            string Detalles = NumCuenta.Text +","+ NameTitular.Text +","+ FehcaVencimiento.Text +","+ CodigoSeguridad.Text;

            FacturaRequest facturaRequest = new FacturaRequest();


            MetodoPagoCompraFa metodoPago = new MetodoPagoCompraFa();
            metodoPago.medio = categoriaSeleccionada.Tipo;
            metodoPago.detalles = Detalles;

            FacturaCli facturaCli = new FacturaCli();
            facturaCli.usuariosId = UsuariosId;
            facturaCli.usuariosTipoId = UsuariosTipoId;

            facturaRequest.metodoPagoCompra = metodoPago;
            facturaRequest.factura = facturaCli;

            var response = await serviceFactura.PostResponse(facturaRequest);

            // Deserializar la lista
            var responseO = Newtonsoft.Json.JsonConvert.DeserializeObject<FacturaResponse>(response);

            // Acceder a los valores
            string res = responseO.result;


            if (res == "Compra realizada con éxito!")
            {
                await DisplayAlert("Mensaje", "Compra realizada con éxito!", "Ok");
            }
            else
            {
                await DisplayAlert("Mensaje", "No creado", "Ok");

            }
        }

        private async void artesano(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainArtesano());
            // DisplayAlert("Alert", "register", "ok");
        }


    }
}