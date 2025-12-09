using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoA3
{
    public class ListaJogos
    {
        //Atributos
        public string nome;
        public float tempoJogado;
        public float preco;
        public Image imagem;


        public ListaJogos(string nome)
        {
            this.nome = nome;
        }
    }
}
