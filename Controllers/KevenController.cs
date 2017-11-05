using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaWeb.Context;

namespace SpaWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/keven")]
    public class KevenController : Controller
    {
        private KevenspaDemoContext _context;
        public KevenController (KevenspaDemoContext context)
        {
            _context = context;
        }

        //Get:
        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok(_context.db_users.ToList());
        }

        [HttpGet("addtest")]
        public IActionResult AddTest()
        {
            _context.db_users.Add(new Models.User()
            {
                Name = DateTime.Now.ToShortDateString(),
                Age = 10,
                Country = ""
            });
            _context.SaveChanges();
            return Ok();
        }

    }
}