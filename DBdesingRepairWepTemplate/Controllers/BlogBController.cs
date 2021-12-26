using DBdesingRepairWepTemplate.Data;
using DBdesingRepairWepTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Controllers
{
    public class BlogBController : Controller
    {
        private readonly AppDbContext _context;

        public BlogBController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            List<Blog> blog = _context.Blogs.ToList();
            return View(blog);
        }
    }
}
