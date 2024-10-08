using AspFinal.DAL;
using AspFinal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Teacher")]
    public class TeachersController : Controller
    {
        private readonly AppDbContext dbContext;
        private readonly IWebHostEnvironment env;
        private readonly UserManager<AppUser> userManager;

        public TeachersController(AppDbContext db, IWebHostEnvironment _env, UserManager<AppUser> _userManager)
        {
            userManager = _userManager;
            dbContext = db;
            env = _env;
        }
        public async Task<IActionResult> Students(AppUser teacher, List<Student> studs)
        {
            teacher = await userManager.FindByNameAsync(User.Identity.Name);
            studs = await dbContext.Students.Where(x => x.GroupId == dbContext.Teachers.FirstOrDefault(x => x.Email == teacher.Email).GroupId).ToListAsync();
            return View(studs);
        }

        public async Task<IActionResult> AddGrade(int? id, Student student)
        {
            student = await dbContext.Students.Include(x=>x.Grades).FirstOrDefaultAsync(x => x.Id == id);
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddGrade(int id, [Bind("Grades,Id")] Student student, int value)
        {
            if (id != student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.Update(student);
                    await dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExists(student.Id))
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
            return View(student);
        }
        private bool StudentExists(int id)
        {
            return dbContext.Groups.Any(e => e.Id == id);
        }

    }
}
