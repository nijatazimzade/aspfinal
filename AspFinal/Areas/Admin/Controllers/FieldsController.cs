using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspFinal.DAL;
using AspFinal.Models;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FieldsController : Controller
    {
        private readonly AppDbContext _context;

        public FieldsController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Fields.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var field = await _context.Fields
                .FirstOrDefaultAsync(m => m.Id == id);
            if (field == null)
            {
                return NotFound();
            }

            return View(field);
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Image, ImageFile,Id")] Field field)
        {
            if (ModelState.IsValid)
            {
                field.Image = field.ImageFile.FileName;
                _context.Add(field);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(field);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var field = await _context.Fields.FindAsync(id);
            if (field == null)
            {
                return NotFound();
            }
            return View(field);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,Image, ImageFile, Id")] Field field)
        {
            if (id != field.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    field.Image = field.ImageFile.FileName;
                    _context.Update(field);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FieldExists(field.Id))
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
            return View(field);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var field = await _context.Fields
                .FirstOrDefaultAsync(m => m.Id == id);
            if (field == null)
            {
                return NotFound();
            }

            return View(field);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var field = await _context.Fields.FindAsync(id);
            _context.Fields.Remove(field);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FieldExists(int id)
        {
            return _context.Fields.Any(e => e.Id == id);
        }
    }
}
