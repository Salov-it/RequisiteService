using MediatR;
using Microsoft.EntityFrameworkCore.Metadata;
using RequisiteService.Application.Interface;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Command.Create
{
    public class CreateRequisiteCommandHandler : IRequestHandler<CreateRequisiteСommand, Requisite>
    {
        public CreateRequisiteCommandHandler(IRequisiteContext context)
        {
            _requisiteContext = context;
        }
        private readonly IRequisiteContext _requisiteContext;
        public async Task<Requisite> Handle(CreateRequisiteСommand request, CancellationToken cancellationToken)
        {
            var content = new Requisite
            {
                id = request.id,
                ownerId = request.ownerId,
                requisiteTypeId = request.requisiteTypeId,
                value = request.value,
                isActivate = true,
                isDelete = false,
                createdAt = DateTime.UtcNow.ToString()
            };

            await _requisiteContext.requisite.AddRangeAsync(content);
            await _requisiteContext.SaveChangesAsync(cancellationToken);
            return content;
        }
        
    }
}
