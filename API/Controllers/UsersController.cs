using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using API.Data;
using API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context= context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUser(){
            return await _context.Users.ToListAsync();
        }


        //  api/users/2

          [HttpGet("{id}")]
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
             return await _context.Users.FindAsync(id);
        }
    }
}