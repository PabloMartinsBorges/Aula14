using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula14;

namespace Aula14
{
    public class Compra: Carrinho
    {
        
        


        public Carrinho()
        {
            this._itens = new Dictionary<Produto, int>();
        }

        public void Recibo(Cliente c)
        {
            dateTime data = new dateTime();
            Console.WriteLine("Compra realizada por:\t{0}", c.Nome);
            Console.WriteLine("Data da compra:\t");
        }

        

        public void Imprimir()
        {
            Console.WriteLine("======== RECIBO ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
            {
                parOrdenado.Key.Imprimir();
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("Subtotal:\tR$ {0:0.00}", parOrdenado.Value * parOrdenado.Key.CalculaValorTotal());
                Console.WriteLine("==========================");
            }
            Console.WriteLine("Total da compra:\tR$ {0:0.00}", this.Total);
            Console.WriteLine("==========================");
        }
    }
}