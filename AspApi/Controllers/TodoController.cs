using MediatR;
using Microsoft.AspNetCore.Mvc;
using DataStore.Todo.Queries;
using DataStore.Todo.Commands;
using DataStore.Todo.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly IMediator mediator;

        public TodoController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<TodoController>

        [HttpGet]
        public async Task<List<TodoModel>> Get()
        {
            return await mediator.Send(new GetTodoListQuery());
        }

        // POST api/<TodoController>
        [HttpPost]
        public async Task<TodoModel> Post([FromBody] TodoModel model)
        {
            var result = new InsertTodoCommand(model);
            return await mediator.Send(result);
            
        }

        /*
        // PUT api/<TodoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        */
        // DELETE api/<TodoController>/5
        [HttpDelete("{id}")]
        public async Task<TodoModel> Delete(int id)
        {
            var model = new DeleteTodoCommand(id);
            return await mediator.Send(model);
        }
    }
}
