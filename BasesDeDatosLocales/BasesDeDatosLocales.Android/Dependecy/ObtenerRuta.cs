using Android.App;
using Android.Content;

using Android.Runtime;
using Android.Views;
using Android.Widget;
using BasesDeDatosLocales.DependencyServ;
using BasesDeDatosLocales.Droid.Dependecy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

//tercer paso

[assembly: Dependency(typeof(ObtenerRuta))]

namespace BasesDeDatosLocales.Droid.Dependecy
{
    //esto es un comentario
    public class ObtenerRuta : IRuta
    {
        public string GetRutaDB(string filename)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(ruta, filename);
        }
    }
}