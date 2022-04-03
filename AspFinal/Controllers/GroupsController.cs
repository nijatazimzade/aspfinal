using AspFinal.DAL;
using AspFinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Controllers
{
    public class GroupsController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<AppUser> userManager;

        public GroupsController(AppDbContext db, UserManager<AppUser> _userManager)
        {
            dbContext = db;
            userManager = _userManager;
        }

        public async Task<IActionResult> Index()
        {
            GroupsViewModel gvm = new GroupsViewModel
            {
                Groups = await dbContext.Groups.ToListAsync(),
                Fields = await dbContext.Fields.ToListAsync(),
            };
            return View(gvm);
        }
        public async Task<IActionResult> Info(int? id)
        {
            Group g1 = await dbContext.Groups.Include(x => x.Field).Include(x => x.Students).FirstOrDefaultAsync(x => x.Id == id);
            return View(g1);
        }

    }
}
