using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisiteService.Application.CQRS.Querries.GetByOwnerQuerry
{
    internal class GetByOwnerValidator : AbstractValidator<GetByOwnerQuerry>
    {
        public GetByOwnerValidator()
        {
            RuleFor(opt => opt.OwnerId).NotEmpty();
            RuleFor(opt => opt.OwnerId).GreaterThan(0);
        }
    }
}
