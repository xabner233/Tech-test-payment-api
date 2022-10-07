using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tech_test_payment_api.Models
{
    public class Pedido : Vendedor
    {
        public int IdPedido { get; set; }
        public  List<string> Itens { get; set; }
        public DateTime Data { get; set; }
        public EnumStatusPedido Status { get; set; }
    
    }
}