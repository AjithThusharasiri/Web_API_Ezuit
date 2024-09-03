using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Test_2.Data;
using Test_2.model;

namespace Test_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;

        public UsersController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.User.ToListAsync();
        }
    }
}
