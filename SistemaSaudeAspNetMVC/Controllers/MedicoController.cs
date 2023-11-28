using Microsoft.AspNetCore.Mvc;
using SistemaSaudeAspNetMVC.Data;
using SistemaSaudeAspNetMVC.Models;

namespace SistemaSaudeAspNetMVC.Controllers
{
    public class MedicoController : Controller
    {
        private readonly ApplicationDbContext _db;

        public MedicoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Medicos> objMedicosList = _db.Medicos;

            return View(objMedicosList);
        }
    }
}
