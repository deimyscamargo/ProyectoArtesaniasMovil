using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BasesDeDatosLocales
{
    class Categoria
    {
        public Categoria(string id, string nombre, string desc)
        {
            _id = id;
            nombreCategoria = nombre;
            descripcion = desc;
        }
        public string _id { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcion { get; set; }
    }
}
