using Plugin.Media.Abstractions;
using Plugin.Media;
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
	public partial class CrearArtesania : ContentPage
	{
        ApiService<Productos> service = new ApiService<Productos>("productos");
        ApiService<Categoria> serviceCategoria = new ApiService<Categoria>("categorias");
        private List<Categoria> categoriasList;

        //aqui FOTOS
        public Productos opciones { get; set; }
        public ImageSource imagenn { get; set; }

        private string usuarioID;
        private string usuarioTipoID;


        public CrearArtesania()
        {
            InitializeComponent();

        }
        public CrearArtesania(string usuarioID, string usuarioTipoID)
        {
            InitializeComponent();
            this.usuarioID = usuarioID;
            this.usuarioTipoID = usuarioTipoID;
            this.BindingContext = opciones;
        }

        //metodo fotos
        public CrearArtesania(Productos opciones)
        {
            InitializeComponent();
            this.opciones = opciones;
            this.BindingContext = opciones;

        }

        //metodos de las fotos

        private async void TakePhoto_Clicked(object sender, EventArgs e)
        {
            var photo = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions());

            if (photo != null)
            {
                Photo.Source = ImageSource.FromStream(() => photo.GetStream());

                imagenn = ImageSource.FromStream(() => photo.GetStream());

                // Verificar que opciones no sea nulo antes de asignar la imagen
                if (opciones != null)
                {
                    opciones.imagen = imagenn.ToString();
                }
            }
        }

        private async void OnSelectPhotoClicked(object sender, EventArgs e)
        {
            var media = CrossMedia.Current;
            if (!media.IsPickPhotoSupported)
            {
                // La selección de fotos no es soportada en este dispositivo
                return;
            }

            var file = await media.PickPhotoAsync();
            if (file == null)
            {
                // El usuario no seleccionó una foto
                return;
            }

            imagenn = Photo.Source = ImageSource.FromFile(file.Path);

            // Verificar que opciones no sea nulo antes de asignar la imagen
            if (opciones != null)
            {
                opciones.imagen = imagenn.ToString();
            }
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

            // Utiliza await dentro de un método asincrónico OnAppearing
            await CargarCategorias();
        }

        public async Task CargarCategorias()
        {
            categoriasList = await serviceCategoria.Get(); // Obtener la lista de categorías
            List<string> nombresCategorias = new List<string>();

            foreach (var categoria in categoriasList)
            {
                nombresCategorias.Add(categoria.nombreCategoria); // Agregar solo el nombre para el Picker
            }

            categoria.ItemsSource = nombresCategorias; // Asignar los nombres al Picker
        }

        private async void mostrarArtesania(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Artesanias());
        }

        private async void crearArtesania(object sender, EventArgs e)
        {
            await CrearProducto();
            await DisplayAlert("Crear artesania", "Artesania registrada con exito", "Ok");

        }

        private async Task<bool> CrearProducto()
        {
            string nombreCategoriaSeleccionada = categoria.SelectedItem as string;

            // Buscar el objeto Categoria seleccionado a partir del nombre
            Categoria categoriaSeleccionada = categoriasList.FirstOrDefault(c => c.nombreCategoria == nombreCategoriaSeleccionada);

            if (categoriaSeleccionada != null)
            {
                Productos producto = new Productos(
                    "",
                    600,
                    nombre.Text,
                    descripcion.Text,
                    Convert.ToInt32(stock.Text),
                    Convert.ToInt32(stock.Text),
                    Convert.ToDecimal(valorCompra.Text),
                    Convert.ToDecimal(valorVenta.Text),
                    "imagen.png",
                    categoriaSeleccionada._id,
                    this.usuarioID,
                    this.usuarioTipoID
                );

                Limpiar();
                return await service.Post(producto);
            }
            else
            {
                // Manejar el caso en que no se encuentra la categoría seleccionada
                return false;
            }

        }

        private void Limpiar()

        {  
            nombre.Text = "";
            stock.Text = "";
            descripcion.Text = "";
            valorCompra.Text = "";
            valorVenta.Text = "";
        }

        private async void IrListaArtesanias(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaArtesanias());

        }
    }
}