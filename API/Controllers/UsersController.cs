using Microsoft.AspNetCore.Mvc;
using API.Data;
using System.Collections.Generic;
using API.Entities;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;
        }
/*
       [HttpGet]
       public ActionResult<IEnumerable<AppUser>>GetUsers()
        {
                var users = _context.Users.ToList();
                return users;
        }
        //api/users/3
        [HttpGet("{Id}")]
       public ActionResult<AppUser>GetUser(int Id)
        {
                var user = _context.Users.Find(Id);
                return user;
        }
*/

      [HttpGet]
       public async Task<ActionResult<IEnumerable<AppUser>>>GetUsers()
        {
                var users = await _context.Users.ToListAsync();
                return users;
        }

      [HttpGet("{Id}")]
       public async Task<ActionResult<AppUser>>GetUser(int Id)
        {
                var user = await _context.Users.FindAsync(Id);
                return user;
        }

    }

   
}