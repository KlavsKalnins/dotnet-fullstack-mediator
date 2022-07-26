using MediatR;
using Microsoft.AspNetCore.Mvc;
using DataStore.Person.Models;
using DataStore.Person.Queries;
using DataStore.Person.Commands;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AspApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IMediator mediator;

        public PersonController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        // GET: api/<PersonController>
        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await mediator.Send(new GetPersonListQuery());
        }

        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public async Task<PersonModel> Get(int id)
        {
            return await mediator.Send(new GetPersonByIdQuery(id));
        }

        // POST api/<PersonController>
        [HttpPost]
        public async Task<PersonModel> Post([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.Name);
            return await mediator.Send(model);
        }

        /*
        // PUT api/<PersonController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        */
        // DELETE api/<PersonController>/5
        [HttpDelete("{id}")]
        public async Task<PersonModel> Delete(int id)
        {
            var model = new DeletePersonCommand(id);
            return await mediator.Send(model);
        }
        
    }
}
