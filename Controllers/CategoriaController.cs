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

        public void AgregarCategoria(Categoria categoria)
        {
            categoriaDao.agregarCategoria(categoria);
        }
        public void EditarCategoria(Categoria categoria)
        {
            categoriaDao.editarCategoria(categoria);
        }
    }
}
