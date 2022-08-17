using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExemploAspNetMVC.Models;

namespace ExemploAspNetMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult FirstAction() {
        return View();
    }

    public string TestQueryString([FromQuery] string q, [FromQuery] string name) {
        return $"Chegou aqui {q} para {name}";
    }

    public string TestForm([FromForm] string name, [FromForm] string email) {
        return $"Nome: {name}, E-mail: {email}";
    }

    public IActionResult Form() {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
