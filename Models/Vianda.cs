using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Models
{
    public class Vianda : EntidadDb
    {
        public string Nombre { get; set; } = null!;
        public List<Receta> Recetas { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public int TiempoPreparacion { get; set; }
    }
}
