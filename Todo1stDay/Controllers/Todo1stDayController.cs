using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Todo1stDay.Controllers
{
    public class Todo1stDayController : Controller
    {
        // GET: Todo1stDayController
        public ActionResult Index(int id)
        {
            if(id==0)
            return View();
            return View("Index1");
        }

        // GET: Todo1stDayController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Todo1stDayController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo1stDayController/Create
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

        // GET: Todo1stDayController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Todo1stDayController/Edit/5
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

        // GET: Todo1stDayController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Todo1stDayController/Delete/5
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
