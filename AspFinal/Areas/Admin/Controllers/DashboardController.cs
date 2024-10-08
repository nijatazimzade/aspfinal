using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspFinal.Areas.Admin.Models;
using AspFinal.DAL;

namespace AspFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, Teacher")]

    public class DashboardController : Controller
    {
        private readonly AppDbContext dbContext;
        public DashboardController(AppDbContext db)
        {
            dbContext = db;
        }
        public async Task<IActionResult> Index()
        {
            DashboardViewModel dvm = new DashboardViewModel();
            dvm.BannerCount = await dbContext.Banners.CountAsync();
            dvm.FieldCount = await dbContext.Fields.CountAsync();
            dvm.GroupCount = await dbContext.Groups.CountAsync();
            dvm.StudentCount = await dbContext.Students.CountAsync();

            return View(dvm);
        }
    }
}
