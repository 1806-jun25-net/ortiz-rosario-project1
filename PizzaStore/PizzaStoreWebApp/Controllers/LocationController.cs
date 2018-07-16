using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Data;

namespace PizzaStoreWebApp.Controllers
{
    public class LocationController : Controller
    {
        public readonly PizzaStoreDBContext _context;

        public LocationController(PizzaStoreDBContext context)
        {
            _context = context; 
        }

        // GET: Location
        public async Task<IActionResult> Index()
        {
            return View(await _context.Locations.ToListAsync());
        }

        // GET: Location/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var locations = await _context.Locations.FirstOrDefaultAsync(l => l.StoreId == id);
            if(locations == null)
            {
                return NotFound();
            }
            return View(locations);
        }

        // GET: Location/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StoreId, StoreLocation")] Locations locations)
        {
           if(ModelState.IsValid)
            {
                _context.Add(locations);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            return View(locations);
                // TODO: Add insert logic here
   
        }


        // GET: Location/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return NotFound(); 
            }

            var locations = await _context.Locations.FindAsync(id); 
            if(locations == null)
            {
                return NotFound();
            }

            return View(locations);
        }

        // POST: Location/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id,[Bind("StoreId, StoreLocation")] Locations locations)
        {


            if(id != locations.StoreId)
            {
                return NotFound(); 
            }

            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(locations);
                    await _context.SaveChangesAsync();
                   // TODO: Add update logic here

                  
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!LocationsExists(locations.StoreId))
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
            return View(locations); 
        }

        private bool LocationsExists(int id)
        {
            return _context.Locations.Any(y => y.StoreId == id);
        }

        // GET: Location/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound(); 
            }

            var locations = await _context.Locations.FirstOrDefaultAsync(x => x.StoreId == id);
            if(locations == null)
            {
                return NotFound();
            }
            return View(locations);
        }

        // POST: Location/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> StoreDeleted(int id)
        {
            var locations = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(locations);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
            
        }
    }
}