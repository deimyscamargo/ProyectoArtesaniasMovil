using System;
using System.Collections.Generic;
using System.Text;

namespace BasesDeDatosLocales
{
    public class Productos
    {
        public string _id { get; set; }
        public decimal precio { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }
        public int stockOriginal { get; set; }
        public decimal valorCompra { get; set; }
        public decimal valorVenta { get; set; }
        public string imagen { get; set; }
        public string categoriasId { get; set; }
        public string usuariosId { get; set; }
        public string usuariosTipoId { get; set; }


        public Productos(string id, decimal precio, string nombre, string descripcion, int stock, int stockOriginal, decimal valorCompra, decimal valorVenta, string imagen, string categoriasId, string usuariosId, string usuariosTipoId)
        {
            this._id = id;
            this.precio = precio;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.stock = stock;
            this.stockOriginal = stockOriginal;
            this.valorCompra = valorCompra;
            this.valorVenta = valorVenta;
            this.imagen = imagen;
            this.categoriasId = categoriasId;
            this.usuariosId = usuariosId;
            this.usuariosTipoId = usuariosTipoId;

        }


    }


}
