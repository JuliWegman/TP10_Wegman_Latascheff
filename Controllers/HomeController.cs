using Microsoft.AspNetCore.Mvc;

namespace TP10.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.listaSeries=BD.ListarSeries();
        return View();
    }
    public List<Temporadas> ListarTemporadas(int IdS){
        return BD.ListarTemporadasPorSerie(IdS);
    }
}
