using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{
    public class CategoriaResponse
    {
        public List<ProductoItem> Productos { get; set; }
        public InformacionAdicionalCategoria InformacionAdicionalCa { get; set; }
    }

    public class ProductoItem
    {
        public string id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string nombre_categoria { get; set; }
        public string img_path { get; set; }
    }

    public class InformacionAdicionalCategoria
    {
        public int fieldCount { get; set; }
        public int affectedRows { get; set; }
        public int insertId { get; set; }
        public string info { get; set; }
        public int serverStatus { get; set; }
        public int warningStatus { get; set; }
        public int changedRows { get; set; }
    }
    public class ProductoEE
    {
        public string id_producto { get; set; }
        public string nombre_producto { get; set; }
        public string nombre_categoria { get; set; }
        public string img_path { get; set; }
    }

    public class Resultado
    {
        public int fieldCount { get; set; }
        public int affectedRows { get; set; }
        public int insertId { get; set; }
        public string info { get; set; }
        public int serverStatus { get; set; }
        public int warningStatus { get; set; }
        public int changedRows { get; set; }
    }

    public class JsonData
    {
    }
    public class CategoriaViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _nombreCategoria;
        public string NombreCategoria
        {
            get { return _nombreCategoria; }
            set
            {
                if (_nombreCategoria != value)
                {
                    _nombreCategoria = value;
                    OnPropertyChanged(nameof(NombreCategoria));
                }
            }
        }

        private string _cantidadProductos;
        public string CantidadProductos
        {
            get { return _cantidadProductos; }
            set
            {
                if (_cantidadProductos != value)
                {
                    _cantidadProductos = value;
                    OnPropertyChanged(nameof(CantidadProductos));
                }
            }
        }

        private ObservableCollection<ProductoEE> _productos;
        public ObservableCollection<ProductoEE> Productos
        {
            get { return _productos; }
            set
            {
                if (_productos != value)
                {
                    _productos = value;
                    OnPropertyChanged(nameof(Productos));
                }
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class ProductExtendidoViewModel
    {
        public ObservableCollection<CategoriaViewModel> Categorias { get; set; }

        public ProductExtendidoViewModel()
        {
            Categorias = new ObservableCollection<CategoriaViewModel>();
        }
    }



    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductExtendido : ContentPage
    {
        private ApiService<JsonData> serviceProductoMasCategorias = new ApiService<JsonData>("/productosapp/categoria");

        public ProductExtendidoViewModel ViewModel { get; set; }

        public ProductExtendido()
        {
            InitializeComponent();

            ViewModel = new ProductExtendidoViewModel();
            BindingContext = ViewModel;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await cargarProductos();
        }

        private async Task cargarProductos()
        {
            var response = await serviceProductoMasCategorias.PostResponse(new JsonData());
            var jsonList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<object>>(response);
            List<ProductoEE> productList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductoEE>>(jsonList[0].ToString());
            var productosAgrupadosPorCategoria = productList.GroupBy(p => p.nombre_categoria);

            foreach (var grupo in productosAgrupadosPorCategoria)
            {
                string nombreCategoria = grupo.Key;
                List<ProductoEE> productosEnCategoria = grupo.ToList();
                string cantidadProductoCategoria = productosEnCategoria.Count.ToString();

                var categoriaViewModel = new CategoriaViewModel
                {
                    NombreCategoria = nombreCategoria,
                    CantidadProductos = cantidadProductoCategoria,
                    Productos = new ObservableCollection<ProductoEE>(productosEnCategoria)
                };

                // Agrega la categoría al ObservableCollection en el ViewModel
                ViewModel.Categorias.Add(categoriaViewModel);
            }

            var hola = "";
        }
    }

}