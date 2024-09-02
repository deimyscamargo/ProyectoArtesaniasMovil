using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microcharts;
using Entry = Microcharts.ChartEntry;
using SkiaSharp;

namespace BasesDeDatosLocales
{

    public class EstadisticasVentaResponse
    {
        public List<EstadisticaVenta> EstadisticasVenta { get; set; }
        public ServerStatus ServerStatus { get; set; }
    }

    public class EstadisticaVenta
    {
        public string ProductoID { get; set; }
        public string ImgPath { get; set; }
        public int ProductosPublicados { get; set; }
        public string ProductosVendidos { get; set; }
        public int Ganancias { get; set; }
    }

    public class ServerStatus
    {
        public int FieldCount { get; set; }
        public int AffectedRows { get; set; }
        public int InsertId { get; set; }
        public string Info { get; set; }
        public int ServerStatusValue { get; set; }
        public int WarningStatus { get; set; }
        public int ChangedRows { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VentasArtesano : ContentPage
    {

        List<Entry> entryList;
        public VentasArtesano()
        {
            InitializeComponent();
            MostrarImagenActual();
            entryList = new List<Entry>();

            loadEntries();

            //asignar los nombres de los entry a los graficos

            barChart.Chart = new BarChart()
            {
                Entries = entryList
            };

        }

        private void loadEntries()
        {
            Entry e1 = new Entry(70)
            {
                Label = "Categoría A",
                ValueLabel = "70",
                Color = SKColor.Parse("#00bcd4")
            };
            Entry e2 = new Entry(300)
            {
                Label = "Categoría B",
                ValueLabel = "300",
                Color = SKColor.Parse("#F44336")
            };
            Entry e3 = new Entry(50)
            {
                Label = "Categoría C",
                ValueLabel = "50",
                Color = SKColor.Parse("#43A047")
               
            };
            Entry e4 = new Entry(500)
            {
                Label = "Categoría D",
                ValueLabel = "500",
                Color = SKColor.Parse("#F9A825")
            };

            entryList.Add(e1);
            entryList.Add(e2);
            entryList.Add(e3);
            entryList.Add(e4);

        }

        private void IrIniciodeSesion(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Login());
        }

        //MOSTRAR EL CARRUCEL
        private string[] imagenes = { "artesania.jpeg", "artesania2.jpeg", "artesania3.jpeg" };
        private int indiceActual = 0;
        private void MostrarImagenActual()
        {
            string rutaImagen = imagenes[indiceActual];
            imagenPrincipal.Source = ImageSource.FromFile(rutaImagen);
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





    }
}