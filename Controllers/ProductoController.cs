using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Models.Dao;

namespace Controllers
{
    public class ProductoController
    {

        ProductoDao productoDao = new ProductoDao();

        public List<Producto> ListarProductos(string buscar)
        {
            return productoDao.listarProductos(buscar);
        }

        public int AgregarProducto(Producto producto)
        {
            return productoDao.agregarProducto(producto);
        }
        public int EditarProducto(Producto producto)
        {
            return productoDao.editarProducto(producto);
        }
    }
}
