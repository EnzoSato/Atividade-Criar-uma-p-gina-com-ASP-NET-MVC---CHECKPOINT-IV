using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Atividade_Criar_uma_p_gina_com_ASP_NET_MVC___CHECKPOINT_IV.Models;

namespace Atividade_Criar_uma_p_gina_com_ASP_NET_MVC___CHECKPOINT_IV.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
