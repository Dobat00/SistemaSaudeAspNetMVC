using Microsoft.AspNetCore.Mvc;
using SistemaSaudeAspNetMVC.Data;
using SistemaSaudeAspNetMVC.Models;

namespace SistemaSaudeAspNetMVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ClienteController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Cliente> objMedicosList = _db.Clientes;

            return View(objMedicosList);
        }
    }
}
