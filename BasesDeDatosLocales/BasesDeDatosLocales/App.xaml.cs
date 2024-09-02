using BasesDeDatosLocales.Data;
using BasesDeDatosLocales.DependencyServ;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasesDeDatosLocales
{
    public partial class App : Application
    {

        private static ProductoDatabase _productoDatabase;
        

        public static ProductoDatabase ProductoDatabase { 
            
            get {
                if (_productoDatabase == null)
                {
                    return _productoDatabase = new ProductoDatabase(DependencyService.Get<IRuta>().GetRutaDB("database.db3"));
                }
                else
                {
                    return _productoDatabase;
                }

            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
