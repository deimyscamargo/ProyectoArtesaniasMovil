using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDeDatosLocales
{
    public class FacturaRequest   
    {
        public MetodoPagoCompraFa metodoPagoCompra { get; set; }
        public FacturaCli factura { get; set; }
    }

    public class MetodoPagoCompraFa
    {
        public string medio { get; set; }
        public string detalles { get; set; }
    }

    public class FacturaCli
    {
        public string usuariosId { get; set; }
        public string usuariosTipoId { get; set; }
    }
}
