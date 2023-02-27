using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisiteService.Application.CQRS.Querries.GetByIdQuerry
{
    internal class GetByIdValidator : AbstractValidator<GetByIdQuerry>
    {
        public GetByIdValidator()
        {
            RuleFor(opt => opt.Id).NotEmpty();
            RuleFor(opt => opt.Id).GreaterThan(0);
        }
    }
}
