using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViandaProject.DTOs
{
    public class GestorRespuesta<T>
    {
        public T Respuesta { get; set; }
        public bool HayError { get; set; }
        public string MensajeError { get; set; }


        public GestorRespuesta(T respuesta)
        {
            Respuesta = respuesta;
            HayError = false;
        }

        public GestorRespuesta(bool hayError, string mensaje)
        {
            HayError = hayError;
            MensajeError = mensaje;
        }


    }
}
