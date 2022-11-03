using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

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
    
    [HttpPost]
    public IActionResult printList(InputNumber inputNumber)
    {
        if (ModelState.IsValid)
        {
            var num1 = inputNumber.EnteredNumber;
            var ListOfIntegers = InputNumberServices.ConvertToIntegerList(num1);
            var AmendedList = InputNumberServices.ConvertToStringList(ListOfIntegers);

            ViewBag.MyList = AmendedList;

        }

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