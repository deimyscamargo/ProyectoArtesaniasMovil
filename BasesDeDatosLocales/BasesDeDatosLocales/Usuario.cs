namespace BasesDeDatosLocales
{
    public class Usuario
    {
        public Usuario(string id, string tipoId, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, string fechaNacimiento, string telefono, string direccion, string correo)
        {
            this._id = id;
            this.tipo_id = tipoId;
            this.primer_nombre = primerNombre;
            this.segundo_nombre = segundoNombre;
            this.primer_apellido = primerApellido;
            this.segundo_apellido = segundoApellido;
            this.fecha_nacimiento = fechaNacimiento;
            this.telefono = telefono;
            this.direccion = direccion;
            this.correo = correo;
        }

        public string _id { get; set; }
        public string tipo_id { get; set; }
        public string primer_nombre { get; set; }
        public string segundo_nombre { get; set; }
        public string primer_apellido { get; set; }
        public string segundo_apellido { get; set; }
        public string fecha_nacimiento { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string correo { get; set; }
    }
}
