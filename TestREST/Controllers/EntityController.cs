using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private IEntityService _service;

        public EntityController(IEntityService ser)
        {
            _service = ser;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public Task<Entity[]> Get()
        {
            return _service.GetEntities();
        }

        [HttpGet("find/{text}")]
        public Task<Entity[]> Find(string text)
        {
            return _service.Find(text);
        }



    }
}
