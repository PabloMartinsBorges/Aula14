using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula14;

namespace Aula14
{
    public class Estoque: Carrinho, IImprimivel
    {
       

        public Estoque()
        {
            this._itens = new Dictionary<Produto, int>();
        }

        

        public void Remover(Produto item, int quantidade)
        {
            if (this._itens.ContainsKey(item))
                this._itens[item] = this._itens[item] - quantidade;
            else
                this._itens[item] = quantidade;
        }

        public void Remover(Produto item)
        {
            this.Adicionar(item, -1);
        }

        public void Imprimir()
        {
            Console.WriteLine("======== ESTOQUE ========");
            foreach (KeyValuePair<Produto, int> parOrdenado in this._itens)
            {
                parOrdenado.Key.Imprimir();
                Console.WriteLine("Quantidade:\t{0}", parOrdenado.Value);
                Console.WriteLine("==========================");
            }
            
            Console.WriteLine("==========================");
        }
    }
}