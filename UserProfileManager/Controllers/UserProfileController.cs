using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserProfileManager.Context;
using UserProfileManager.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserProfileManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfileController : ControllerBase
    {
        private UserContext _context; 
        public UserProfileController(UserContext context)
        {
            _context = context;
        }
        // GET: api/<UserProfileController>
        [HttpGet]
        public IEnumerable<UsersProfile> Get()
        {
            return _context.UsersProfiles.ToList();
        }

        // GET api/<UserProfileController>/5
        [HttpGet("{id}")]
        public UsersProfile Get(int id)
        {
            return _context.UsersProfiles.Where(i => i.Id == id).FirstOrDefault();
        }

        // POST api/<UserProfileController>
        [HttpPost]
        public void Post([FromBody] UsersProfile value)
        {
            _context.UsersProfiles.Add(value);
            _context.SaveChanges();
        }       

        // DELETE api/<UserProfileController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var item = _context.UsersProfiles.Where(i => i.Id == id).FirstOrDefault();
            _context.UsersProfiles.Remove(item);
            _context.SaveChanges();
        }
    }
}
