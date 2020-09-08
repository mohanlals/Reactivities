using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private DataContext _Context { get; }

        public ValuesController(DataContext context)
        {
            _Context = context;

        }
        [HttpGet]
        public async Task< ActionResult<IEnumerable<Value>>> Get()
        {
            var values = await _Context.values.ToListAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task <ActionResult<string>> Get(int id)
        {
            var values=await _Context.values.FindAsync(id);
            return Ok(values);
        }

    }
}