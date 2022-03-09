using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Ingrediente
    {
        public string nombre { get; set; }
        public int cantidadEnGramos { get; set; }
        public List<Categoria> categorias { get; set; }
    }
}
