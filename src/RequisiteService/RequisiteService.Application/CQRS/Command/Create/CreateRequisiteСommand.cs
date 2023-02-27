using MediatR;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Command.Create
{
    public class CreateRequisiteСommand : IRequest<Requisite>
    {
        public int id { get; set; }
        public int ownerId { get; set; }
        public int requisiteTypeId { get; set; }
        public int value { get; set; }
        public bool isActivate { get; set; }
        public bool isDelete { get; set; }
    }
}
