using Microsoft.AspNetCore.Mvc;
using Sistema_Venda_SI.Model.Models;

namespace Sistema_Venda_SI.Controllers
{
    public class TipoPagamentoController : Controller
    {
        private readonly DBSISTEMASContext _context;

        public TipoPagamentoController(DBSISTEMASContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var ListaTipoPagamento = _context.TipoPagamento.ToList();

            return View(ListaTipoPagamento);
        }

        public IActionResult Details(int id) 
        {
            TipoPagamento tipoPagamento = new TipoPagamento();
            tipoPagamento = _context.TipoPagamento.FirstOrDefault(x => x.TpgCodigo == id);
            return View(tipoPagamento);
        }

        public IActionResult Edit(int id)
        {
            var tipoPagamento = _context.TipoPagamento.FirstOrDefault(x =>x.TpgCodigo == id);
            return View(tipoPagamento);
        }

        [HttpPost]

        public IActionResult Edit(TipoPagamento tipoPagamento)
        {
            if (ModelState.IsValid)
            {
                _context.Entry<TipoPagamento>(tipoPagamento).State = Microsoft.EntityFrameworkCore.EntityState.Modified; 
                _context.SaveChanges();
                return View(tipoPagamento);
            }
            ViewData["MensagemErro"] = "Erro no sistema";
                return View(tipoPagamento);
        }

        [HttpPost]
        public IActionResult Create(TipoPagamento tipoPagamento) 
        {
            if (ModelState.IsValid) 
            {
                _context.Entry(tipoPagamento).State = Microsoft.EntityFrameworkCore.EntityState.Added;
                _context.SaveChanges();
                return View(tipoPagamento);
            }
            ViewData["MensagemErro"] = "Erro no sistema";
            return View(tipoPagamento);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();  
        }



      
        public IActionResult Delete(int id)
        {
            var tipoPagamento = _context.TipoPagamento.FirstOrDefault(x => x.TpgCodigo == id);

            if (tipoPagamento != null)
            {
                _context.Entry(tipoPagamento).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                _context.SaveChanges();
            }
            else
            {
                ViewData["MensagemErro"] = "Tipo de pagamento não encontrado.";
            }

            return View(tipoPagamento);
        }

    }
}
