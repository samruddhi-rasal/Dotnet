using Microsoft.AspNetCore.Mvc;
namespace Ecommerce.Controllers;
using ECommerce.Models;
public class CustomerController : Controller
{
    //action methods:

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult AboutUs()
    {
         string content = "Doing ordinary things extraordinarily well is the key to success.";
        ViewData["Message"] = content;
        return View();
    }

    public IActionResult ContactUs()
    {
         Address address = new Address
        {
            Street = "601, Pune Satar Road",
            City = "Pune",
            State = "MH",
            ZipCode = "41009"
        };
        ViewData["Address"] = address;

        return View();
    }
}