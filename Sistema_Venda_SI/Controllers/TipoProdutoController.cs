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
            var ListaTipoProduto = _context.TipoProduto.ToList();

            return View(ListaTipoProduto);
        }

        public IActionResult Details(int id) 
        {
            TipoProduto tipoProduto = new TipoProduto();
            tipoProduto = _context.TipoProduto.FirstOrDefault(x => x.TipCodigo == id);
            return View(tipoProduto);
        }

        public IActionResult Edit(int id)
        {
            var tipoProduto = _context.TipoProduto.FirstOrDefault(x =>x.TipCodigo == id);
            return View(tipoProduto);
        }

        [HttpPost]

        public IActionResult Edit(TipoProduto tipoProduto)
        {
            if (ModelState.IsValid)
            {
                _context.Entry<TipoProduto>(tipoProduto).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
                _context.SaveChanges();
                return View(tipoProduto);
            }
            ViewData["MensagemErro"] = "Erro no sistema";
                return View(tipoProduto);
        }

        [HttpPost]
        public IActionResult Create(TipoProduto tipoProduto) 
        {
            if (ModelState.IsValid) 
            {
                _context.Entry(tipoProduto).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _context.SaveChanges();
                return View(tipoProduto);
            }
            ViewData["MensagemErro"] = "Erro no sistema";
            return View(tipoProduto);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();  
        }



      
        public IActionResult Delete(int id)
        {
            var tipoProduto = _context.TipoProduto.FirstOrDefault(x => x.TipCodigo == id);

            if (tipoProduto != null)
            {
                _context.Entry(tipoProduto).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
            }
            else
            {
                ViewData["MensagemErro"] = "Tipo de pagamento não encontrado.";
            }

            return View(tipoProduto);
        }

    }
}