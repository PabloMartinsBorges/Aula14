using System.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula14;

namespace Aula14
{
public class Licensa : Produto
{
    
    protected string _chaveAtivacao;

    public string ChaveAtivacao
    {
        get { return this._chaveAtivacao; }
    }

    public Licensa(string nome, double preco, string chaveAtivacao)
    {
        this._nome = nome;
        this._preco = preco;
        this._chaveAtivacao = chaveAtivacao;
    }

    public override double CalculaValorTotal()
    {
        return this._preco;
    }

    public override void Imprimir()
    {
        Console.WriteLine("Software:\t{0}", this.Nome); 
        Console.WriteLine("Valor:\t\tR$ {0:0.00}", this.CalculaValorTotal());
        Console.WriteLine("Fornecedor:\t{0}", this.fornecedor.Nome);
    }
}
}