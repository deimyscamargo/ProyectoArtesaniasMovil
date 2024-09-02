using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace BasesDeDatosLocales
{
    internal class Credenciales
    {
        public Credenciales(string _id, string usuario, string contrasena, string Usuarios__id, string Usuarios_tipo_id)
        {
            this._id = _id;
            this.usuario = usuario;
            this.contrasena = contrasena;
            this.usuariosId = Usuarios__id;
            this.usuariosTipoId = Usuarios_tipo_id;
        }

        public string _id { get; set; }
        public string usuario { get; set; }
        public string contrasena { get; set; }
        public string usuariosId { get; set; }
        public string usuariosTipoId { get; set; }
    }
}
