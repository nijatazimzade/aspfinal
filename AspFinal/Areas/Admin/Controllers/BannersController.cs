using AspFinal.DAL;
using AspFinal.Models;
using AspFinal.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Teacher")]
    public class BannersController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IWebHostEnvironment env;
        public BannersController(AppDbContext db, IWebHostEnvironment _env)
        {
            dbContext = db;
            env = _env;
        }
        public async Task<IActionResult> Index()
        {
            return View(await dbContext.Banners.ToListAsync());
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(Banner banner)
        {
            if (!ModelState.IsValid) return View();
            Banner duplicate = await dbContext.Banners.FirstOrDefaultAsync(x => x.Title == banner.Title);
            if (duplicate != null)
            {
                ModelState.AddModelError("Title", "Title must be unique.");
                return View();
            }

            await dbContext.Banners.AddAsync(banner);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Banners");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return RedirectToAction("Index", "Banners");
            Banner banner = await dbContext.Banners.FindAsync(id);
            if (banner == null) return RedirectToAction("Index", "Banners");
            return View(banner);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return RedirectToAction("Index", "Banners");
            Banner Banner = await dbContext.Banners.FindAsync(id);
            if (Banner == null) return RedirectToAction("Index", "Banners");
            return View(Banner);
        }
        public async Task<IActionResult> DeleteConfirmed(int? id)
        {
            if (id == null) return RedirectToAction("Index", "Banners");
            Banner BannerToDelete = await dbContext.Banners.FindAsync(id);
            if (BannerToDelete == null) return RedirectToAction("Index", "Banners");

            dbContext.Banners.Remove(BannerToDelete);
            await dbContext.SaveChangesAsync();

            return RedirectToAction("Index", "Banners");
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return RedirectToAction("Index", "Banners");
            Banner Banner = await dbContext.Banners.FindAsync(id);
            if (Banner == null) return RedirectToAction("Index", "Banners");
            return View(Banner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Banner Banner)
        {
            if (!ModelState.IsValid) return View();

            dbContext.Banners.Update(Banner);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Index", "Banners");
        }
    }
}
