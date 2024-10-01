using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Duyen158.Models;
using Duyen158.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Duyen158.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public PersonController(ApplicationDbcontext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var person = await _context.Persons.ToListAsync();
            return View(person);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person person)
        {
            if (ModelState.IsValid)
            {
                await _context.Persons.AddAsync(person);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(person);
        }
        public async Task<IActionResult> Edit(int ID)
        {
            var person = await _context.Persons.FirstOrDefaultAsync(p => p.ID == ID);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
         public async Task<IActionResult> Edit(Person person)
         {
            if (!ModelState.IsValid)
            {
                _context.Persons.Update(person);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(person);
         }
        public async Task<IActionResult> Delete(int Id)
        {
            var person = await _context.Persons.FirstOrDefaultAsync(p => p.ID == Id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int Id)
        {
            var person = await _context.Persons.FirstOrDefaultAsync(p => p.ID == Id);
            if (person != null)
            {
                _context.Persons.Remove(person); 
                await _context.SaveChangesAsync(); 
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int id)
        {
            var person = await _context.Persons.FirstOrDefaultAsync(p => p.ID == id);
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
        }

    }
}