using Microsoft.AspNetCore.Mvc;

namespace ASP_Chat.Controllers;

public class ChatController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
