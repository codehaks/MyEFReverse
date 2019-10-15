using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyEFReverse.Data;

namespace MyEFReverse.Controllers
{
    public class AlbumController : Controller
    {
        private readonly ChinookContext _db;

        public AlbumController(ChinookContext db)
        {
            _db = db;
        }

        [Route("api/albums")]
        public IActionResult Index()
        {
            return Ok(_db.Albums);
        }
    }
}