using DACS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DACS.Areas.Admin.Controllers
{
    public class ManagerController : Controller
    {
        [Area("Admin")]
        [Authorize(Roles = UserRoleModel.Role_Admin)]
        public IActionResult Index()
        {
            return View();
        }
    }
}
