using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BasesDeDatosLocales.Data
{
    public class ProductoDatabase
    {
        private readonly SQLiteAsyncConnection database;
        public ProductoDatabase(string ruta) {
            database = new SQLiteAsyncConnection(ruta);
            database.CreateTableAsync<Producto>().Wait();
        
        }

        public async Task<List<Producto>> GetProductos()
        {
            return await database.Table<Producto>().ToListAsync();

        }

        public async Task<Producto> GetOneProducto(int id)
        {
            return await database.Table<Producto>().Where(x=>x.Id==id).FirstOrDefaultAsync();
        }

        public async Task<int > DeleteProducto(Producto producto)
        {
            return await database.DeleteAsync(producto);
        }
        public  async Task<int> GuardarProducto(Producto producto)
        {
            return await database.InsertAsync(producto);
        }

        public async Task<int> ActualizarProducto(Producto producto)
        {
            return await database.UpdateAsync(producto);
        }
    }
}
