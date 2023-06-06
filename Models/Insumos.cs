using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Models
{
    public class Insumos : EntidadDb
    {
        public string Nombre { get; set; } = null!;
        public string Descripción { get; set; } = null!;
        public int Costo { get; set; }
    }
}
