using MediatR;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Querries.Get
{
    public class GetRequisiteQuery : IRequest<List<Requisite>>
    {

    }
}
