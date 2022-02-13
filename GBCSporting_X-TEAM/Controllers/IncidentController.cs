using Microsoft.AspNetCore.Mvc;
using GBCSporting_X_TEAM.Models;

namespace GBCSporting_X_TEAM.Controllers
{
    public class IncidentController : Controller
    {
        private GbcSportingContext context { get; set; }

        public IncidentController(GbcSportingContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Incident());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var incident = context.Incidents.Find(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if (incident.IncidentId == 0)
                    context.Incidents.Add(incident);
                else
                    context.Incidents.Update(incident);
                context.SaveChanges();
                return RedirectToAction("Incidents", "Home");
            }
            else
            {
                ViewBag.Action = (incident.IncidentId == 0) ? "Add" : "Edit";
                return View(incident);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var incident = context.Incidents.Find(id);
            return View(incident);
        }

        [HttpPost]
        public IActionResult Delete(Incident incident)
        {
            context.Incidents.Remove(incident);
            context.SaveChanges();
            return RedirectToAction("Incidents", "Home");
        }
    }
}
