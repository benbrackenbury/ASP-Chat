using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Chat.Controllers;

[Authorize]
public class ChatController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
