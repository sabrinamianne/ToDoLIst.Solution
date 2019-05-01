using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
     public ActionResult Index()
    {
      return View();
    }

    [Produces("text/html")]
     [Route("/favorite_photos")]
     public ActionResult FavoritePhotos()
     {
       return View();
     }


  }
}
