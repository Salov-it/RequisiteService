using MediatR;
using RequisiteService.Application.CQRS.Command.Create;
using RequisiteService.Application.Interface;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Command.UpdateRequisite
{
    public class UpdateRequisiteCommandHandler : IRequestHandler<UpdateRequisiteCommand, Requisite>
    {
        private readonly IRequisiteContext _context;
        public UpdateRequisiteCommandHandler(IRequisiteContext context)
        {
            _context = context;
        }
        public async Task<Requisite> Handle(UpdateRequisiteCommand request, CancellationToken cancellationToken)
        {
            var content = _context.requisite.Find(request.id);

            if (content == null)
            {
                // Exception
                return null;
            }

            content.requisiteTypeId = request.requisiteTypeId;
            content.value = request.value;
            content.isActivate = request.isActivate;
            content.updatedAt = DateTime.UtcNow.ToString();

            await _context.SaveChangesAsync(cancellationToken);

            return content;
        }

       
    }
}
