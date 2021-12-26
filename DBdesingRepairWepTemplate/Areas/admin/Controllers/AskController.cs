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
    public class AskController : Controller
    {
        private readonly AppDbContext _context;

        public AskController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            return View(_context.Asks.ToList());
        }

        [HttpGet]
        public IActionResult Create()
        {


            
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ask model)
        {

            if (ModelState.IsValid)
            {
                _context.Asks.Add(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

                ModelState.AddModelError("","aeee erorr");
                return View(model);

            }
        }
        [HttpGet]

        public IActionResult Update(int Id)
        {


            return View(_context.Asks.Find(Id));
        }

        [HttpPost]
        public IActionResult Update(Ask model)
        {

            if (ModelState.IsValid)
            {
                _context.Asks.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {

              
                return View(model);

            }
        }
        [HttpGet]

        public IActionResult Delete(int? Id)
        {
            if (Id==null)
            {
                return NotFound();
            }


            Ask ask = _context.Asks.Find(Id);

            if (ask==null)
            {
                return NotFound();
            }
            _context.Asks.Remove(ask);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
