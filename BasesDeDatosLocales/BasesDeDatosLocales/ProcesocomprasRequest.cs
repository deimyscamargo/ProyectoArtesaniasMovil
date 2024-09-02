using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDeDatosLocales
{
    public class ProcesocomprasRequest
    {
        public MetodoPagoCompraPr MetodoPagoCompra { get; set; }
        public FacturaP Factura { get; set; }
    }

    public class MetodoPagoCompraPr
    {
        public string Medio { get; set; }
        public string Detalles { get; set; }
    }

    public class FacturaP
    {
        public string UsuariosId { get; set; }
        public string UsuariosTipoId { get; set; }
    }

}
