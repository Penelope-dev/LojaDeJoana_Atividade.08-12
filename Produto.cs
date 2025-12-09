
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Atividade_08_de_dez
{
    public class Produto
    {
        public string Nome { get; set; }

        public int Quantidade { get; set; }

        public double Preco { get; set; }


        public double ValorTotal()
        {
            return Preco * Quantidade;
        }
    }
}

