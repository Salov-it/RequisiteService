using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisiteService.Application.CQRS.Command.UpdateRequisite
{
    internal class UpdateCommandValidator : AbstractValidator<UpdateRequisiteCommand>
    {
        public UpdateCommandValidator()
        {
            RuleFor(opt => opt.id).NotEmpty();
            RuleFor(opt => opt.id).GreaterThan(0);
            RuleFor(opt => opt.requisiteTypeId).GreaterThan(0);
            RuleFor(opt => opt.value).GreaterThan(0);
            RuleFor(opt => opt.isActivate).GreaterThan(0);
        }
    }
}
