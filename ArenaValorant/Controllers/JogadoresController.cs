using ArenaValorant.Data;
using Microsoft.AspNetCore.Mvc;

namespace ArenaValorant.Controllers
{
    public class JogadoresController : Controller
    {
        private ArenaDbContext _context;

        public JogadoresController(ArenaDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
