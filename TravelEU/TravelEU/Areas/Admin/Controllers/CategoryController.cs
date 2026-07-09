using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelEU.Database.Context;

namespace TravelEU.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly TravelEUDbContext _context;

        public CategoryController(TravelEUDbContext context)
        {
            _context = context;
        }

        // Hiển thị danh sách Category
        public IActionResult Index()
        {
            var categories = _context.Categories.ToList();

            return View(categories);
        }

        // Hiển thị form Create
        public IActionResult Create()
        {
            return View();
        }

        // Xử lý khi bấm nút Lưu
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TravelEU.Database.Models.Category category)
        {
            if (ModelState.IsValid)
            {
                category.CreatedDate = DateTime.Now;

                _context.Categories.Add(category);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(category);
        }
    }
}