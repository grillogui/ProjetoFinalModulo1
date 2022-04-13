using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalRoupas.src
{
    public class Camisa : Roupa
    {
        public Camisa(string _tamanho, string _cor, string _marca, double _preco, int _quantidade) : base(_tamanho, _cor, _marca, _preco, _quantidade)
        {
            Tipo = "Camisa";
        }

        public Camisa()
        {
            Tipo = "Camisa";
        }
    }
}
