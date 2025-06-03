using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Models.Dao;

namespace Controllers
{
    public class MedidaController
    {
        MedidaDao medidaDao = new MedidaDao();
        public List<Medida> ListarMedidas()
        {
            return medidaDao.listarMedidas();
        }
    }
}
