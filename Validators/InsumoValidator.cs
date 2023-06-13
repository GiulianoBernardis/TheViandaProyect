using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheViandaProject.Models;

namespace TheViandaProject.Validators
{
    public class InsumoValidator : AbstractValidator<Insumo>
    {
        public InsumoValidator()
        {
            RuleFor(x => x.Nombre).NotEmpty().WithMessage("El nombre es obligatorio");
            RuleFor(x => x.Costo).NotEmpty().WithMessage("El costo es obligatorio").GreaterThan(0).WithMessage("El costo tiene que ser mayor a 0");
        }
    }
}
