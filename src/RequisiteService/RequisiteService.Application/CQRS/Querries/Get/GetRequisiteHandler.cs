using MediatR;
using Microsoft.EntityFrameworkCore;
using RequisiteService.Application.Interface;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Querries.Get
{
    public class GetRequisiteHandler : IRequestHandler<GetRequisiteQuery, List<Requisite>>
    {
        private readonly IRequisiteContext _context;
        public GetRequisiteHandler(IRequisiteContext context)
        {
            _context = context;
        }

        public async Task<List<Requisite>> Handle(GetRequisiteQuery request, CancellationToken cancellationToken)
        {

            return await _context.requisite.ToListAsync(cancellationToken);
        }
    }
}
