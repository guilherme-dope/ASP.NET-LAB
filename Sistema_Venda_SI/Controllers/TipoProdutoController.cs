using Microsoft.AspNetCore.Mvc;
using Sistema_Venda_SI.Model.Models;

namespace Sistema_Venda_SI.Controllers
{
    public class TipoProdutoController : Controller
    {
        private readonly DBSISTEMASContext _context;

        public TipoProdutoController(DBSISTEMASContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(TipoProduto tipoProduto) 
        {
            if (ModelState.IsValid)
            {
                _context.Entry(tipoProduto).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _context.SaveChanges();
            }
            return View(tipoProduto);
        }
    }
}
