using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Project_08.Models;

namespace Project_08.Controllers
{
    public class CarTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CarTypesController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult MultipleDataInsert()
        {
            return View();
        }

        [HttpPost]
        public JsonResult MultipleDataInsert(string subjectJson)
        {
            var js = new JsonSerializer();

            CarType[] carTypes = (CarType[])Newtonsoft.Json.JsonConvert.DeserializeObject(subjectJson, typeof(CarType[]));
            foreach(CarType c in carTypes)
            {
                c.Id = 0;
            }

            try
            {

                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.CarType.AddRange(carTypes);
                        _context.SaveChanges();
                        dbContextTransaction.Commit();
                        return Json("Data are inserted in Subject Table");
                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        return Json("There is a Probem arise");
                    }


                }
            }
            catch (Exception ex)
            {
                string ksks = ex.Message;
            }

            return Json("There is a Probem arise");

        }

        // GET: CarTypes
        //[ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Index()
        {
            return View(await _context.CarType.ToListAsync());
        }

        // GET: CarTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carType = await _context.CarType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carType == null)
            {
                return NotFound();
            }

            return View(carType);
        }

        // GET: CarTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CarTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Create([Bind("Id,Cartype1")] CarType carType)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(carType);
        }

        // GET: CarTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carType = await _context.CarType.FindAsync(id);
            if (carType == null)
            {
                return NotFound();
            }
            return View(carType);
        }

        // POST: CarTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Cartype1")] CarType carType)
        {
            if (id != carType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarTypeExists(carType.Id))
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
            return View(carType);
        }

        // GET: CarTypes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var carType = await _context.CarType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (carType == null)
            {
                return NotFound();
            }

            return View(carType);
        }

        // POST: CarTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carType = await _context.CarType.FindAsync(id);
            _context.CarType.Remove(carType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarTypeExists(int id)
        {
            return _context.CarType.Any(e => e.Id == id);
        }
    }
}
