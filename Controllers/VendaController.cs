using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using tech_test_payment_api.Entities;
using tech_test_payment_api.Context;

namespace tech_test_payment_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {

        private readonly ControleVendasContext _context;

        public VendaController(ControleVendasContext context) 
        {
            _context = context;
        }
         
         [HttpPost]
         public IActionResult Create(Venda venda)
         {  
            _context.Add(venda);
            _context.SaveChanges();
            return Ok(venda);
         }

         [HttpGet("{idVenda}")]
         public IActionResult ObterPorIdVenda(int idVenda)
         {
            var venda = _context.Vendas.Find(idVenda);
            
            if (venda == null)
                return NotFound();


            return Ok(venda);
         }
    }
}