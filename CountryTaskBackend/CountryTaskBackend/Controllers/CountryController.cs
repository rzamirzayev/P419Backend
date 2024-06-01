using CountryTaskBackend.Models.Contexts;
using CountryTaskBackend.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace CountryTaskBackend.Controllers
{
    public class CountryController : Controller
    {
        private readonly DataContext db;

        public CountryController(DataContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var students = db.Countries.ToList();

            return View(students);
        }

        public IActionResult Details(int id)
        {
            var student = db.Countries.Where(m => m.Id == id).FirstOrDefault();

            return View(student);
        }

        public IActionResult Edit(int id)
        {
            var student = db.Countries.Where(m => m.Id == id).FirstOrDefault();

            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Country model)
        {
            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country model)
        {
            db.Countries.Add(model);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Remove(int id)
        {
            var student = db.Countries.Where(m => m.Id == id).FirstOrDefault();


            db.Countries.Remove(student);
            db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
