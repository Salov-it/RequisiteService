using MediatR;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Querries.GetByIdQuerry
{
    public class GetByIdQuerry : IRequest<Requisite>
    {
        public int Id { get; set; }
    }
}
