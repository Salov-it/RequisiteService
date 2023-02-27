using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequisiteService.Application.CQRS.Command.Create
{
    public class CreateCommandValidator : AbstractValidator<CreateRequisiteСommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(query => query.ownerId).GreaterThan(0);
        }
    }
}
