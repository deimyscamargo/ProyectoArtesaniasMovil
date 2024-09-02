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
	public partial class PRODUCTO : ContentPage
	{
		public PRODUCTO ()
		{
			InitializeComponent();


            // Crear un Label
            Label miLabel = new Label
            {

                Text = "Mario Benedetti",
                FontSize = 0,
                TextColor = Color.FromHex("#3A3A3A"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

         

            // Agregar un GestureRecognizer al Label para detectar el tap
            TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) =>
            {

                Navigation.PushAsync(new Artesanias());

            };

            // Asignar el TapGestureRecognizer al Label
            miLabel.GestureRecognizers.Add(tapGestureRecognizer);

            btns.Children.Insert(-1, miLabel);
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

        private async void AgregarCarrito(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Carrito());
            // DisplayAlert("Alert", "register", "ok");
        }

        private async void Factura(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Factura());
            // DisplayAlert("Alert", "register", "ok");
        }







    }
}