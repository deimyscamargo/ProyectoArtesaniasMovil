using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDeDatosLocales
{
    internal class Roles
    {
        
        public Roles(string _id, string tipo, string Usuarios__id, string Usuarios_tipo_id)
        {
            this._id = _id;
            this.tipo = tipo;
            this.Usuarios__id = Usuarios__id;
            this.Usuarios_tipo_id = Usuarios_tipo_id;
        }

        public string _id { get; set; }
        public string tipo { get; set; }
        public string Usuarios__id { get; set; }
        public string Usuarios_tipo_id { get; set; }

    }
}
