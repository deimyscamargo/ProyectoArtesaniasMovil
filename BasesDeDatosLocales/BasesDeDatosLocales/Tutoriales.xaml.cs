using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{

    public class VideoResponse
    {
        public VideoItem Video { get; set; }
        public InformacionAdicionalVideo InformacionAdicionalVideo { get; set; }
    }

    public class VideoItem
    {
        public string VideoID { get; set; }
        public string VideoURL { get; set; }
        public string VideoTitulo { get; set; }
        public DateTime VideoFecha { get; set; }
        public string VideoDescripcion { get; set; }
    }

    public class InformacionAdicionalVideo
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
	public partial class Tutoriales : ContentPage
	{
		public Tutoriales ()
		{
            InitializeComponent();

            // Crear un Label
            Label miLabel = new Label
            {

                Text = "Artesanias",
                FontSize = 20,
                TextColor = Color.FromHex("#3A3A3A"),
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            // Crear un Label2
            Label miLabel2 = new Label
            {
                Text = "Tutoriales",
                FontSize = 20,
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

            // Agregar un GestureRecognizer al Label para detectar el tap
            TapGestureRecognizer tapGestureRecognizer2 = new TapGestureRecognizer();
            tapGestureRecognizer2.Tapped += (s, e) =>
            {
                Navigation.PushAsync(new Tutoriales());

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