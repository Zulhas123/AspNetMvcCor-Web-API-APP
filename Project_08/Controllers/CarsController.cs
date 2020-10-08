using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Project_08.Models;

namespace Project_08.Controllers
{
    public class CarsController : Controller
    {
        private readonly ApplicationDbContext _context;
        IHostingEnvironment _evn;

        public CarsController(ApplicationDbContext context, IHostingEnvironment evn)
        {
            _evn = evn;
            _context = context;
        }

        // GET: Cars
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Car.Include(c => c.CarType);
            return View(await applicationDbContext.ToListAsync());
        }



        public IActionResult MultipleDataInsert()
        {
            return View();
        }

        [HttpPost]
        public JsonResult MultipleDataInsert(string subjectJson)
        {
            var js = new JsonSerializer();

            Car[] subjects = (Car[])Newtonsoft.Json.JsonConvert.DeserializeObject(subjectJson, typeof(Car[]));

            try
            {

                using (var dbContextTransaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        _context.Car.AddRange(subjects);
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




        // GET: Cars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .Include(c => c.CarType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // GET: Cars/Create
        public IActionResult Create()
        {
            ViewData["CarTypeId"] = new SelectList(_context.CarType, "Id", "Id");
            return View();
        }

        // POST: Cars/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Create([Bind("Id,Name,Model,price,IsAvailable,ImageUrl,CarTypeId")] Car car, IFormFile formFile)
        {
            if (ModelState.IsValid)
            {


                try
                {
                    using (var strem = new FileStream(_evn.WebRootPath + "\\Image\\" + formFile.FileName, FileMode.Create))
                    {
                        formFile.CopyTo(strem);
                    }
                    car.ImageUrl = "/Image/" + formFile.FileName;


                    _context.Add(car);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return View();
                }

              
            }
            ViewData["CarTypeId"] = new SelectList(_context.CarType, "Id", "Id", car.CarTypeId);
            return View(car);
        }

        // GET: Cars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car.FindAsync(id);
            if (car == null)
            {
                return NotFound();
            }
            ViewData["CarTypeId"] = new SelectList(_context.CarType, "Id", "Id", car.CarTypeId);
            return View(car);
        }

        // POST: Cars/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //[ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Model,price,IsAvailable,ImageUrl,CarTypeId")] Car car, IFormFile formFile)
        {
            if (id != car.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (formFile != null)
                    {
                        using (var strem = new FileStream(_evn.WebRootPath + "\\Image\\" + formFile.FileName, FileMode.Create))
                        {
                            formFile.CopyTo(strem);
                        }
                        car.ImageUrl = "/Image/" + formFile.FileName;

                    }


                    _context.Update(car);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }            
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarExists(car.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction(nameof(Index));
            }
            ViewData["CarTypeId"] = new SelectList(_context.CarType, "Id", "Id", car.CarTypeId);
            return View(car);
        }

        // GET: Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _context.Car
                .Include(c => c.CarType)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (car == null)
            {
                return NotFound();
            }

            return View(car);
        }

        // POST: Cars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        //[ServiceFilter(typeof(CommonActionFilter))]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var car = await _context.Car.FindAsync(id);
            _context.Car.Remove(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarExists(int id)
        {
            return _context.Car.Any(e => e.Id == id);
        }
    }
}
