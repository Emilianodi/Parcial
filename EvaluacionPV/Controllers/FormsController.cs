using EvaluacionPV.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace EvaluacionPV.Controllers
{
    public class FormsController : Controller
    {


       public static  List<IDtributaria> tributaria = new List<IDtributaria>();

        // Resto del código del controlador

        public IActionResult Index()
        {
            return View(tributaria);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IDtributaria tarea)
        {
            tarea.Id = tributaria.Count + 1;
            tarea.Id = tributaria.Count + 1;
            tributaria.Add(tarea);
            return RedirectToAction("Index");
        }
    }
}

    


