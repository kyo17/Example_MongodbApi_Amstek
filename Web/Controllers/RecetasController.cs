using Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RecetasController : Controller
    {
        private readonly IReceta repo;
        public RecetasController(IReceta service)
        {
            repo = service; 
        }

        [HttpGet]
        public async Task<IActionResult> getAll()
        {
            return Ok(await repo.getAll());
        }

        [HttpPost]
        public async Task<IActionResult> saveOne([FromBody] Receta receta)
        {
            await repo.saveOne(receta);
            return Created("", true);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteOne(string id)
        {
            await repo.deleteOne(id);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> updateOne([FromBody] Receta receta)
        {
           
            await repo.updateOne(receta);
            return Created("", true);
        }

    }
}
