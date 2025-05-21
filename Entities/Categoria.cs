using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Categoria
    {
        public Categoria()
        {
        }

        public int IdCategoria { get; set; }
        public string Nombre { get; set; }
        public Medida oMedida { get; set; }
        public int Activo { get; set; }



    }
}
