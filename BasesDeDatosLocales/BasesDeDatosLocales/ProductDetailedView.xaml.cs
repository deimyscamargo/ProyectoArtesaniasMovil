using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{
    public class DetalleProductoResponse
    {
        public List<DetalleProductoItem> DetalleProducto { get; set; }
        public InformacionAdicionalDetalle InformacionAdicional { get; set; }
    }

    public class DetalleProductoItem
    {
        public string id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public string img_path { get; set; }
        public int stock { get; set; }
        public decimal valor_venta { get; set; }
        public string nombre_categoria { get; set; }
        public string id_usuario { get; set; }
        public string primer_nombre_usuario { get; set; }
        public string primer_apellido_usuario { get; set; }
    }

    public class InformacionAdicionalDetalle
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
    public partial class ProductDetailedView : ContentPage
    {

        public string userID { get; set; }
        public string userTipoID { get; set; }

        public ProductDetailedView(string userID, string userTipoID)
        {
            InitializeComponent();
            this.userID = userID;
            this.userTipoID = userTipoID;
        }
        private void OnDecrementClicked(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(QuantityLabel.Text);
            if (currentQuantity > 0)
            {
                currentQuantity -= 1;
                QuantityLabel.Text = currentQuantity.ToString();
            }
        }

        private void OnIncrementClicked(object sender, EventArgs e)
        {
            int currentQuantity = int.Parse(QuantityLabel.Text);
            currentQuantity += 1;
            QuantityLabel.Text = currentQuantity.ToString();
        }

        private async void Carrito(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carrito(userID, userTipoID));
            // DisplayAlert("Alert", "register", "ok");
        }

        private async void Factura(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Factura());
            // DisplayAlert("Alert", "register", "ok");
        }

    }
}