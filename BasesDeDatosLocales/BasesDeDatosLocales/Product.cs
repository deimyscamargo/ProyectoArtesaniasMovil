using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BasesDeDatosLocales
{
      public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private List<string> images;
        public List<string> Images
        {
            get { return images; }
            set
            {
                images = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Images)));
            }
        }

        public MainViewModel()
        {
            // Rutas de las imágenes que deseas mostrar en el CarouselView
            Images = new List<string>
            {
                "slider1.jpg",
                "slider2.jpg",
                "slider3.jpg",
                "hamacas1.jpg",
                "sombrero1.jpg",
                "manilla.jpg"
            };
        }
    }
    
    }

