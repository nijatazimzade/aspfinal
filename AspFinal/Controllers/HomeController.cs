using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.DAL;
using AspFinal.Models;

namespace AspFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<AppUser> userManager;

        public HomeController(AppDbContext db, UserManager<AppUser> _userManager)
        {
            dbContext = db;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                Banners = await dbContext.Banners.ToListAsync(),
                Fields = await dbContext.Fields.ToListAsync(),
                Features = await dbContext.Features.ToListAsync(),
                Groups = await dbContext.Groups.ToListAsync(),
                Users = await userManager.Users.Where(x => x.IsActive == true).ToListAsync()
            };

            return View(hvm);



        }
    }
}
