

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
    public partial class ListaArtesanias : ContentPage
    {
        public ListaArtesanias()
        {
            InitializeComponent();

            // Otro código de inicialización...

            // Agregar evento Clicked al Frame
            miFrame.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    // Lógica que se ejecutará cuando se haga clic en el Frame
                    HandleFrameClick();
                })
            });
        }



        private void HandleFrameClick()
        {
            Navigation.PushAsync(new CrearArtesania());

        }


        private void MiBoton_Clicked(object sender, EventArgs e)
        {
            // Lógica que se ejecuta cuando se hace clic en el botón
            Navigation.PushAsync(new VentasArtesano());
        }

        private void IrIniciodeSesion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());

        }

        private void IraCrearArtesanias(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CrearArtesania());

        }

        private void IrSubirVideos(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SubirVideos());

        }
    }
}