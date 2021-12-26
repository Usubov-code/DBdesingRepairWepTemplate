using DBdesingRepairWepTemplate.Data;
using DBdesingRepairWepTemplate.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBdesingRepairWepTemplate.Areas.admin.Controllers
{
    [Area("admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Blogs.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Blog blog)
        {
            if (ModelState.IsValid)
            {
                _context.Blogs.Add(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

                ModelState.AddModelError("", "aeee erorr");
                return View(blog);

            }


            return View(blog);
        }
        public IActionResult Update(int Id)
        {


            return View(_context.Blogs.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(Blog blog)
        {

            if (ModelState.IsValid)
            {
                _context.Blogs.Update(blog);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {


                return View(blog);

            }
        }
        [HttpGet]

        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }


            Blog blog = _context.Blogs.Find(Id);

            if (blog == null)
            {
                return NotFound();
            }
            _context.Blogs.Remove(blog);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
