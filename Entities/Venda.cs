using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Entities
{
    public class Venda
    {        
        public int Id { get; set; }
        public string NomeVendedor { get; set; }       
        public int IdVendedor { get; set; }
        public string Cpf { get; set; }        
        public string Email { get; set; }
        public int Telefone { get; set; }          
        public  string ItemVendido { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusPedido Status { get; set; }      
     
    }
}