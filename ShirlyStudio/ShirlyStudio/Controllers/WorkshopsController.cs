﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ShirlyStudio.Models;
using WebApplication4.Models;
using System.Web.Optimization;

namespace ShirlyStudio.Controllers
{
    public class WorkshopsController : Controller
    {
        private readonly ShirlyStudioContext _context;

        public WorkshopsController(ShirlyStudioContext context)
        {
            _context = context;
        }

        //for graphs
        [HttpGet]
        public JsonResult GetRecordsMonthly()
        {
            return Json(_context.Workshop.OrderBy(n => n.FullData).ToList());
        }
        //for graphs
        [HttpGet]
        public JsonResult Getfreeplace()
        {
            return Json(_context.Workshop.OrderBy(n => n.FullData).ToList());
        }

        //join function
        public JsonResult Tryjoin()
        {
            var list =  from Workshop in _context.Workshop
                        join Customer in _context.Customer on Workshop.Name equals Customer.Name
                        select new { Name=Workshop.Name ,Workshop.Price };
            var result = list.GroupBy(w => w.Name).Select(t => new { id =t.Key, counter = t.Sum(u => u.Price) }).OrderByDescending(c=> c.counter).Take(5);
            return Json(result.ToList());
        }

        public async Task<IActionResult> Index()
        {

            return View(await _context.Workshop.OrderBy(n => n.FullData).ToListAsync());
        }

        // להוסיף עוד 2 משתנים בקלט


        public async Task<IActionResult> Filter(string Name, int price, int available_members)
        {

            // אותה שאילתה לשלושתם רק נדרש להגדיר את המשתנים
            if (Name == null && price == 0 && available_members == 0) return Json(await _context.Workshop.OrderBy(n => n.FullData).ToListAsync());
            //  if (Name == null) Name = "";
            if (available_members == 0 && price == 0 && Name != null)
            {

                var m = await (from c in _context.Workshop
                                   //לתקן את התנאים - בגללם כל התוצאות יוצאות
                               where (c.Name.Contains(Name))
                               orderby c.FullData
                               select c).ToListAsync();
                return Json(m);
            }
            else if (available_members == 0 && price != 0 && Name == null)
            {
                var q = await (from c in _context.Workshop
                                   //לתקן את התנאים - בגללם כל התוצאות יוצאות
                               where (c.Price <= price)
                               orderby c.FullData
                               select c).ToListAsync();
                return Json(q);

            }
            else if (available_members == 0 && price != 0 && Name != null)
            {
                var q = await (from c in _context.Workshop
                                   //לתקן את התנאים - בגללם כל התוצאות יוצאות
                               where (c.Price <= price)
                               where (c.Name.Contains(Name))

                               orderby c.FullData
                               select c).ToListAsync();
                return Json(q);

            }
            else if (available_members != 0 && price == 0 && Name != null)
            {
                var q = await (from c in _context.Workshop
                                   //לתקן את התנאים - בגללם כל התוצאות יוצאות
                               where (c.Available_Members >= available_members)
                               where (c.Name.Contains(Name))

                               orderby c.FullData
                               select c).ToListAsync();
                return Json(q);
            }
            else if (available_members != 0 && price != 0 && Name == null)
            {
                var q = await (from c in _context.Workshop
                                   //לתקן את התנאים - בגללם כל התוצאות יוצאות
                               where (c.Available_Members >= available_members)
                               where (c.Price <= price)

                               orderby c.FullData
                               select c).ToListAsync();
                return Json(q);

            }

            else if (available_members != 0 && price == 0 && Name == null)
            {
                var q = await (from c in _context.Workshop
                                   //לתקן את התנאים - בגללם כל התוצאות יוצאות
                               where (c.Available_Members >= available_members)

                               orderby c.FullData
                               select c).ToListAsync();
                return Json(q);
            }
            else
            {
                var q = await (from c in _context.Workshop
                                   //לתקן את התנאים - בגללם כל התוצאות יוצאות
                               where (c.Available_Members >= available_members)
                               where (c.Price <= price)
                               where (c.Name.Contains(Name))
                               orderby c.FullData
                               select c).ToListAsync();
                return Json(q);

            }


        }



        // GET: Workshops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workshop = await _context.Workshop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workshop == null)
            {
                return NotFound();
            }

            return View(workshop);
        }

        // GET: Workshops/Create
        public IActionResult Create()
        {
            ViewBag.WorkshopCategory = new SelectList(_context.Category.Include(c => c.WorkshopCategory), "Id", "Name");
            return View();
        }

        // POST: Workshops/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,FullData,Price,Available_Members,Description,WorkshopCategory")] Workshop workshop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(workshop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(workshop);
        }

        // GET: Workshops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workshop = await _context.Workshop.FindAsync(id);
            if (workshop == null)
            {
                return NotFound();
            }
            return View(workshop);
        }

        // POST: Workshops/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,FullData,Price,Available_Members,Description")] Workshop workshop)
        {
            if (id != workshop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(workshop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WorkshopExists(workshop.Id))
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
            return View(workshop);
        }

        // GET: Workshops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var workshop = await _context.Workshop
                .FirstOrDefaultAsync(m => m.Id == id);
            if (workshop == null)
            {
                return NotFound();
            }

            return View(workshop);
        }

        // POST: Workshops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var workshop = await _context.Workshop.FindAsync(id);
            _context.Workshop.Remove(workshop);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WorkshopExists(int id)
        {
            return _context.Workshop.Any(e => e.Id == id);
        }
    }
}
