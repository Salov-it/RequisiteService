using MediatR;
using RequisiteService.Domain;

namespace RequisiteService.Application.CQRS.Command.UpdateRequisite
{
    public class UpdateRequisiteCommand : IRequest<Requisite>
    {
        public int id { get; set; }
        public int requisiteTypeId { get; set; }
        public int value { get; set; }
        public int isActivate { get; set; }
        public string updatedAt { get; set; }
    }
}
