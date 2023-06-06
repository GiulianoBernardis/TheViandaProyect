using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Models
{
    public class MateriaPrima : EntidadDb
    {
        public int Cantidad { get; set; }
        public string Nombre { get; set; } = null!;
        public int Costo { get; set; }
        public string UnidadMedida { get; set; } = null!;
    }
}
