using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDeDatosLocales
{
    internal class RegisterRequest
    {
        public string p_id { get; set; }
        public string p_tipo_id { get; set; }
        public string p_primer_nombre { get; set; }
        public string p_segundo_nombre { get; set; }
        public string p_primer_apellido { get; set; }
        public string p_segundo_apellido { get; set; }
        public string p_fecha_nacimiento { get; set; }
        public string p_telefono { get; set; }
        public string p_direccion { get; set; }
        public string p_correo { get; set; }
        public string p_tipo_rol { get; set; }
        public string p_usuario { get; set; }
        public string p_contrasena { get; set; }

    }
}
