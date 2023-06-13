using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.DTOs;
using TheViandaProject.Models;
using TheViandaProject.Servicios;
using TheViandaProject.Validators;

namespace TheViandaProject.Controllers
{
    public class InsumoController
    {
        private InsumosService insumosService;

        public InsumoController()
        {
            insumosService = new InsumosService();
        }
        public GestorRespuesta<Insumo> Registrar(Insumo insumo)
        {
            var validación = new InsumoValidator();
            var resultado = validación.Validate(insumo);

            if (resultado.IsValid)
            {
                var resultadoregistro = insumosService.Registrar(insumo);
                if (resultadoregistro.HayError)
                {
                    return new GestorRespuesta<Insumo>(true, resultadoregistro.MensajeError);
                }
                else
                {
                    return new GestorRespuesta<Insumo>(resultadoregistro.Respuesta);
                }
            }
            else
            {
                return new GestorRespuesta<Insumo>(true, resultado.ToString());
            }
        }

        public Insumo? ObtenerPorId(int ID)
        {

        }

        public List<Insumo> ObtenerTodos()
        {

        }

        public GestorRespuesta<Insumo> Modificar(Insumo insumo)
        {

        }

        public bool CambiarEstado(int id, bool estado)
        {

        }
    }
}
