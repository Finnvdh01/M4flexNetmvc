using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using newssite.Models;

namespace newssite.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<NewsItem> newsItems = new List<NewsItem>();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        newsItems.Add(new NewsItem()
        {
            Title = "mijn eerste model",
            Content = "was niet zo moeilijk om te maken.",
            imageUrl = "img/newsitem.png"
        });

        newsItems.Add(new NewsItem()
        {
            Title = "mijn tweede model",
            Content = "was ook niet zo moeilijk om te maken.",
            imageUrl = "img/newsitem.png"
        });

        newsItems.Add(new NewsItem()
        {
            Title = "mijn derde model",
            Content = "was ook niet zo moeilijk om te maken.",
            imageUrl = "img/newsitem.png"
        });

        newsItems.Add(new NewsItem()
        {
            Title = "mijn vierde model",
            Content = "was ook niet zo moeilijk om te maken.",
            imageUrl = "img/newsitem.png"
        });
    }

    public IActionResult Index()
    {
        return View(newsItems);
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
