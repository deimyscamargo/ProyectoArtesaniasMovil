using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

//SEGUNDO PASO
namespace BasesDeDatosLocales
{
    public class Producto
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public  string nombre { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }

    }
}
