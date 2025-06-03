using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Models.Dao;

namespace Controllers
{
    public class CategoriaController
    {
        CategoriaDao categoriaDao = new CategoriaDao();

        public List<Categoria> ListarCategorias(string buscar)
        {
            return categoriaDao.listarCategorias(buscar);
        }

        public int AgregarCategoria(Categoria categoria)
        {
            return categoriaDao.agregarCategoria(categoria);
        }
        public int EditarCategoria(Categoria categoria)
        {
           return categoriaDao.editarCategoria(categoria);
        }
    }
}
