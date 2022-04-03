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
    public class StudentsController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly UserManager<AppUser> userManager;

        public StudentsController(AppDbContext db, UserManager<AppUser> _userManager)
        {
            dbContext = db;
            userManager = _userManager;
        }
        public async Task<IActionResult> Info(int? id)
        {
            Student s1 = await dbContext.Students.Include(x=>x.Group).Include(x => x.Group.Field).FirstOrDefaultAsync(x => x.Id == id);
            return View(s1);

        }
    }
}
