using CQRSTest.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSTest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : Controller
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator )
        {
            _mediator = mediator;
        }
        // GET api/customers
        //[HttpGet]
        //public async Task<ActionResult<CustomersListViewModel>> GetAll()
        //{
        //    return Ok(await _mediator.Send(new GetCustomersListQuery()));
        //}

        //// GET api/customers/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return Ok(await _mediator.Send(new GetCustomerDetailQuery { Id = id }));
        //}

        //// POST api/customers
        //[HttpPost]
        //public async Task<IActionResult> Create([FromBody] CreateCustomerCommand command)
        //{
        //    return Ok(await _mediator.Send(command));
        //}

        //// PUT api/customers/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Update(int id, [FromBody] UpdateCustomerCommand command)
        //{
        //    if (command == null || command.Id != id)
        //    {
        //        return BadRequest();
        //    }

        //    return Ok(await _mediator.Send(command));
        //}

        //// DELETE api/customers/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //    await _mediator.Send(new DeleteCustomerCommand { Id = id });

        //    return NoContent();
        //}
    }
}
