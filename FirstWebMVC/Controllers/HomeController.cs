using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;

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
    public IActionResult Index(string FullName, string Address)
    {
        string strOutput = " Xin chào " + FullName + " đến từ " + Address;
        ViewBag.Message = strOutput;
        return View();
    }
    public IActionResult BMI()
    {
        return View();
    }
    [HttpPost]
    public IActionResult BMI(double Weight, double Height)
    {
        double bmi = Weight / (Height * Height);
        string strOutput;
        if (bmi < 18.5)
            strOutput = "Gầy";
        else if (bmi < 24.9)   
            strOutput = "Bình thường";
        else if (bmi < 29.9)   
            strOutput = "Thừa cân";       
        else    
            strOutput = "Béo phì";

        ViewBag.BMI = bmi;    
        ViewBag.Message = strOutput;
        return View();
    }
    public IActionResult Score()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Score(double A, double B, double C)
    {
        double total = A * 0.6 + B * 0.3 + C * 0.1;
        ViewBag.Message = total;    
        return View();
    }
     public IActionResult Bill()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Bill(int soluong, double dongia)
    {
        double tong = soluong * dongia;
        ViewBag.Message = tong;    
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
