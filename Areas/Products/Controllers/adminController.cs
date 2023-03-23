using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormationAspMvcApp.Areas.Products.Controllers
{
    public class adminController : Controller
    {
        // GET: adminController
        [Area("products")]
        public ActionResult Index()
        {
            return View();
        }

        // GET: adminController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: adminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: adminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: adminController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: adminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: adminController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: adminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
