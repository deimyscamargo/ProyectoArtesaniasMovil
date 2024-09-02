using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDeDatosLocales
{
    internal class Videos
    {
        public string id { get; set; }
        public string urlVideo { get; set; }
        public string titulo { get; set; }
        public DateTime fecha { get; set; }
        public string descripcion { get; set; }
        public string usuariosId { get; set; }
        public string usuariosTipoId { get; set; }

        public Videos(string id, string urlVideo, string titulo, DateTime fecha, string descripcion, string usuariosId, string usuariosTipoId)
        {
            this.id = id;
            this.urlVideo = urlVideo;
            this.titulo = titulo;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.usuariosId = usuariosId;
            this.usuariosTipoId = usuariosTipoId;
        }
    }
}
