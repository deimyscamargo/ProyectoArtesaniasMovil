using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MostrarTodosApi : ContentPage
    {
        
        public MostrarTodosApi(List<Producto> listado)
        {
            InitializeComponent();
            listadoProductos.ItemsSource = listado;
        }

        private async void Eliminar(object sender, EventArgs e)
        {
            var productoEliminar = await ObtenerProducto();
            await App.ProductoDatabase.DeleteProducto(productoEliminar);
        }

        private async void BuscarUno(object sender, EventArgs e)
        {
            var produc = await ObtenerProducto();
            nombre.Text = produc.nombre;
            precio.Text = Convert.ToString(produc.precio);
            cantidad.Text = Convert.ToString(produc.cantidad);
        }

        private async Task<Producto> ObtenerProducto()
        {
            return await App.ProductoDatabase.GetOneProducto(Convert.ToInt32(id.Text));
        }
    }
}