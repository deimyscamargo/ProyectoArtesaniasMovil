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
	public partial class MainArtesano : ContentPage
	{
        public MainArtesano()
        {
            InitializeComponent();

            // Crear un Label
            Label miLabel = new Label
            {

                Text = "Subir Tutoriales    ",
                FontSize = 20,
                TextColor = Color.FromHex("#3A3A3A"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            // Crear un Label2
            Label miLabel2 = new Label
            {
                Text = "  Crear Artesanias",
                FontSize = 20,
                TextColor = Color.FromHex("#3A3A3A"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            // Agregar un GestureRecognizer al Label para detectar el tap
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {

                Navigation.PushAsync(new Tutoriales());

            };

            // Agregar un GestureRecognizer al Label para detectar el tap
            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new CrearArtesania());

            };

            // Asignar el TapGestureRecognizer al Label
            miLabel.GestureRecognizers.Add(tapGestureRecognizer);

            btns.Children.Insert(-1, miLabel);

            // Asignar el TapGestureRecognizer al Label
            miLabel2.GestureRecognizers.Add(tapGestureRecognizer2);

            btns.Children.Insert(-1, miLabel2);
        }
    }
}