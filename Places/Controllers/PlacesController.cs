using Microsoft.AspNetCore.Mvc;
using Travel.Models;
using System.Collections.Generic;

namespace Travel.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allPlaces = Place.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName)
    {
      Place myPlaces = new Place(cityName);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult Delete()
    {
      Place.ClearAll();
      return View();
    }
  }
}