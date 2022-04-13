using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalRoupas.src
{
    public class Estoque : Loja
    {
        public Estoque() {
            Roupa = new List<Roupa>();
        }
        public List<Roupa> Roupa { get; set; }

        public void Adicionar(Roupa roupa)
        {
            Roupa.Add(roupa);
        }

        public void Remover(Roupa roupa)
        {
            Roupa.Remove(roupa);
        }

        public override string Entregar()
        {
            return "A roupa está a caminho";
        }

    }

}
