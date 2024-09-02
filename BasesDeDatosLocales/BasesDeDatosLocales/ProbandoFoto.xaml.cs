using Plugin.Media;
using Plugin.Media.Abstractions;
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
    public partial class ProbandoFoto : ContentPage
    {



        public ProbandoFoto()
        {
            InitializeComponent();

            var htmlcontent = new HtmlWebViewSource();
            htmlcontent.Html = "<html><head> </head><body>" 
                + "<iframe width='560' height='315' src='https://www.youtube.com/embed/gIt4hv501Bc?si=KtbviByP65V2-RsK' "+" frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' allowfullscreen></iframe>" + "</body></html>";
            video.Source = htmlcontent;
            video.WidthRequest = 30;
            video.HeightRequest = 150;
        }
      
  

      

    }
}