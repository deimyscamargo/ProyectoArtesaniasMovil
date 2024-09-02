using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDeDatosLocales
{
    public class MetodoPagoCompra
    {
        public string _id { get; set; }
        public string medio { get; set; }
        public string detalles { get; set; }

        public MetodoPagoCompra(string id, string medio, string detalles)
        {
            this._id = id;
            this.medio = medio;
            this.detalles = detalles;

        }

    }


}