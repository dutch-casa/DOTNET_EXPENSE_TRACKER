using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DotNetExpenseTracker.Models;

namespace DotNetExpenseTracker.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly ExpensesDbContext _context;

    public HomeController(ILogger<HomeController> logger, ExpensesDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Expenses()
    {
        return View();
    }

    public IActionResult CreateEditExpense() 
    {
        return View(); 
    }

    public IActionResult CreateEditExpenseForm(Expense model)
    {
        _context.Expenses.Add(model);
        _context.SaveChanges();

        return RedirectToAction("Expenses");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
