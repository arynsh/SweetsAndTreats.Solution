using Microsoft.AspNetCore.Mvc;
using Pierre.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Pierre.Controllers
{
  public class TreatsController : Controller
  {
    private readonly PierreContext _db;

    public TreatsController(PierreContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Flavor> model = _db.Flavors.ToList();
      return View(model);
    }
    // public ActionResult Create()
    // {
    //   ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
    //   return View();
    // }
    // [HttpPost]
    // public ActionResult Create(Treat treat, int FlavorId)
    // {
    //     _db.Treats.Add(treat);
    //     if (FlavorId != 0)
    //     {
    //         _db.FlavorTreat.Add(new FlavorTreat() { FlavorId = FlavorId, TreatId = treat.TreatId});
    //     }
    //     _db.SaveChanges();
    //     return RedirectToAction("Index");
    // }
    // public ActionResult Details(int id)
    // {
    //     var thisTreat = _db.Treats
    //         .Include(treat => treat.Flavors)
    //         .ThenInclude(join => join.Flavor)
    //         .FirstOrDefault(treat => treat.TreatId == id);
    //     return View(thisTreat);
    // }
    // public ActionResult Edit(int id)
    // {
    //   var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
    //   ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
    //   return View(thisTreat);
    // }
    // [HttpPost]
    // public ActionResult Edit(Treat treat, int FlavorId)
    // {
    //   // Treat previousTreat = _db.Treats.Include(treats => treats.Flavors).ThenInclude(join => join.Flavor).FirstOrDefault(treats => treats.TreatId == treat.TreatId);
    //   FlavorTreat join = _db.FlavorTreat.FirstOrDefault(flaTreat => flaTreat.FlavorId == FlavorId && catTreat.TreatId == treat.TreatId);
    //   if (FlavorId != 0 && join == null)
    //   {
    //       _db.FlavorTreat.Add(new FlavorTreat() { FlavorId = FlavorId, TreatId = treat.TreatId});
    //   }
    //   _db.Entry(treat).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddFlavor(int id)
    // {
    //     var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
    //     ViewBag.FlavorId = new SelectList(_db.Flavors, "FlavorId", "Name");
    //     return View(thisTreat);
    // }
    // [HttpPost]
    // public ActionResult AddFlavor(Treat treat, int FlavorId)
    // {
    //     if (FlavorId != 0)
    //     {
    //         _db.FlavorTreat.Add(new FlavorTreat() {FlavorId = FlavorId, TreatId = treat.TreatId});
    //     }
    //     _db.SaveChanges();
    //     return RedirectToAction("Index");
    // }
    // public ActionResult Delete(int id)
    // {
    //   var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
    //   return View(thisTreat);
    // }
    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisTreat = _db.Treats.FirstOrDefault(treats => treats.TreatId == id);
    //   _db.Treats.Remove(thisTreat);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
    // [HttpPost]
    // public ActionResult DeleteFlavor(int joinId)
    // {
    //     var joinEntry = _db.FlavorTreat.FirstOrDefault(entry => entry.FlavorTreatId == joinId);
    //     _db.FlavorTreat.Remove(joinEntry);
    //     _db.SaveChanges();
    //     return RedirectToAction("Index");
    // }
    // [HttpPost]
    // public ActionResult MarkAsCompleted(int id)
    // {
    //   var thisTreat = _db.Treats
    //       .FirstOrDefault(treat => treat.TreatId == id);
    //   thisTreat.Completed = true;
    //   _db.Entry(thisTreat).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // [HttpPost]
    //  public ActionResult MarkAsUnCompleted(int id)
    // {
    //   var thisTreat = _db.Treats
    //       .FirstOrDefault(treat => treat.TreatId == id);
    //   thisTreat.Completed = false;
    //   _db.Entry(thisTreat).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}