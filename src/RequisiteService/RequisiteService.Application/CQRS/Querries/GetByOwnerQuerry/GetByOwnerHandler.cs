using MediatR;
using Microsoft.EntityFrameworkCore;
using RequisiteService.Application.Interface;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Querries.GetByOwnerQuerry
{
    public class GetByOwnerHandler : IRequestHandler<GetByOwnerQuerry, Requisite>
    {
        private readonly IRequisiteContext _context;
        public GetByOwnerHandler(IRequisiteContext context)
        {
            _context = context;
        }
        public async Task<Requisite> Handle(GetByOwnerQuerry request, CancellationToken cancellationToken)
        {
            var requisite = await _context.requisite.FirstOrDefaultAsync(w => w.ownerId == request.OwnerId);
            if (requisite == null)
            {
                return null;
            }

            return requisite;
        }
    }
}
