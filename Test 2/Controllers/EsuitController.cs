using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_2.Data;
using Test_2.model;


namespace Test_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EsuitController : Controller
    {
        private readonly DataContext _context;

        public EsuitController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Esuit>>> GetEsuit()
        {
            return await _context.Esuit.ToListAsync();
        }
    }
}
