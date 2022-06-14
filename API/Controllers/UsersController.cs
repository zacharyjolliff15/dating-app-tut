using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class UsersController : ControllerBase //use dependency injection
    {
        private readonly DataContext _context; //access to our database with _context
        public UsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet] //getting data in this case
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList(); //return the results of the database operation

        
        }

        [HttpGet("{id}")] //specify a root parameter
        //api/users/3   gets the user of the id 3. 
        public ActionResult<AppUser> GetUser(int id)
        {
            return _context.Users.Find(id); //finds an entity with the given primary key

        }


    }
}