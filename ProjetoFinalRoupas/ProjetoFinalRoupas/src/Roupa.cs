using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalRoupas.src
{
    public class Roupa : Estoque
    {
        public string Tipo { get; set; }
        public string Tamanho { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }   
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Roupa(string _tamanho, string _cor, string _marca, double _preco, int _quantidade)
        {
            Tipo = "";
            Tamanho = _tamanho;
            Cor = _cor;     
            Marca = _marca;
            Preco = _preco;
            Quantidade = _quantidade;
        }

        public Roupa() { }

    }
}
