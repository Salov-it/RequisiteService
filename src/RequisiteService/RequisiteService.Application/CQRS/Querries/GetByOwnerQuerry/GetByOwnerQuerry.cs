using MediatR;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Querries.GetByOwnerQuerry
{
    public class GetByOwnerQuerry : IRequest<Requisite>
    {
        public int OwnerId { get; set; }
    }
}
