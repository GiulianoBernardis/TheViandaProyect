using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.Models
{
     public abstract class EntidadDb
     {
        public int Id { get; set; }
        public DateTime Registro { get; set; }
        public DateTime Modificacion { get; set; }
        public bool Deshabilitado { get; set; }
     }
}
