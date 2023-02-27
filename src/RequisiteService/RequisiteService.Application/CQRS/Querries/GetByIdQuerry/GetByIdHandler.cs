using MediatR;
using Microsoft.EntityFrameworkCore;
using RequisiteService.Application.Interface;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Querries.GetByIdQuerry
{
    internal class GetByIdHandler : IRequestHandler<GetByIdQuerry, Requisite>
    {
        private readonly IRequisiteContext _requisiteContext;
        public GetByIdHandler(IRequisiteContext requisiteContext)
        {
            _requisiteContext = requisiteContext;
        }
        public async Task<Requisite> Handle(GetByIdQuerry request, CancellationToken cancellationToken)
        {
            return await _requisiteContext.requisite.FirstOrDefaultAsync(w => w.id == request.Id, cancellationToken);
        }
    }
}
