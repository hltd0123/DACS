using DACS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DACS.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = UserRoleModel.Role_Admin)]
    public class ManagerController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
