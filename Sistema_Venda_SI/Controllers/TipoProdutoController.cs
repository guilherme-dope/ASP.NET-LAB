using Microsoft.AspNetCore.Mvc;
using Sistema_Venda_SI.Model.Models;

namespace Sistema_Venda_SI.Controllers
{
    public class TipoProdutoController : Controller
    {
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
            return View(tipoProduto);
        }
    }
}
