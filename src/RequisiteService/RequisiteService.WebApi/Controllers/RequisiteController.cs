using MediatR;
using Microsoft.AspNetCore.Mvc;
using RequisiteService.Application.CQRS.Command.Create;
using RequisiteService.Application.CQRS.Querries.GetByOwnerQuerry;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RequisiteService.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RequisiteController : ControllerBase
    {
        private readonly IMediator mediator;

        public RequisiteController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] int ownerId, int requisiteTypeId, int value)
        {
            var content = new CreateRequisiteСommand
            {
               
                ownerId = ownerId,
                requisiteTypeId = requisiteTypeId,
                value = value,
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }

        [HttpGet]
        public async Task<IActionResult> GetByOwner(int ownerId)
        {
            var content = new GetByOwnerQuerry
            {
                OwnerId = ownerId,
            };
            var answer = await mediator.Send(content);
            return Ok(answer);
        }
    }

}
