using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using s2.Models;

namespace s2.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly HttpClient _httpClient = new HttpClient();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
/*        var timer = new System.Timers.Timer(300);
        Responce personLocations = new();
        timer.Elapsed += async (s, e) =>
        {
            while (true)
            { 
                var responce = await _httpClient.GetAsync("http://localhost:4914/PersonLocations");
                if (responce.IsSuccessStatusCode)
                {
                    var data = await responce.Content.ReadAsStringAsync();
                    personLocations = JsonConvert.DeserializeObject<Responce>(data);
                }
            }
        };
        timer.Start();*/
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
