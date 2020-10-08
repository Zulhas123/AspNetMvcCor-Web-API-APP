using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project_08.Models;

namespace Project_08.Controllers
{
    public class CarOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CarOrders
        //[ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Index1()
        {
            return View(await _context.CarOrder.ToListAsync());
        }
        public async Task<IActionResult> Index(string sortOrder,  string currentFilter, string searchString,  int? pageNumber)
        {
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["CurrentFilter"] = searchString;
            ViewData["CurrentSort"] = sortOrder;

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }


            var students = from s in _context.CarOrder
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString));
            }



            switch (sortOrder)
            {
                case "name_desc":
                    students = students.OrderByDescending(s => s.Name);
                    break;               
                default:
                    students = students.OrderBy(s => s.Name);
                    break;
            }
            int pageSize = 3;
            return View(await PaginatedList<CarOrder>.CreateAsync(students.AsNoTracking(), pageNumber ?? 1, pageSize));
        }
        // GET: CarOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carOrder = await _context.CarOrder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carOrder == null)
            {
                return NotFound();
            }

            return View(carOrder);
        }

        // GET: CarOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Create([Bind("Id,OrderNo,Name,Email,Address,OrderDate")] CarOrder carOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carOrder);
        }

        // GET: CarOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carOrder = await _context.CarOrder.FindAsync(id);
            if (carOrder == null)
            {
                return NotFound();
            }
            return View(carOrder);
        }

        // POST: CarOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Edit(int id, [Bind("Id,OrderNo,Name,Email,Address,OrderDate")] CarOrder carOrder)
        {
            if (id != carOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarOrderExists(carOrder.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(carOrder);
        }

        // GET: CarOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carOrder = await _context.CarOrder
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carOrder == null)
            {
                return NotFound();
            }

            return View(carOrder);
        }

        // POST: CarOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carOrder = await _context.CarOrder.FindAsync(id);
            _context.CarOrder.Remove(carOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarOrderExists(int id)
        {
            return _context.CarOrder.Any(e => e.Id == id);
        }
    }
}
