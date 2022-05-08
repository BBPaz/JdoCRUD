using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdoCRUD.Model
{
    public class Tabuleiro
    {
        private int id;
        private string nomeTabuleiro;
        private string imagemTabuleiro;
        private DateTime dtCriacao;
        private string corTematica;

        public int Id { get => id; set => id = value; }
        public string NomeTabuleiro { get => nomeTabuleiro; set => nomeTabuleiro = value; }
        public string ImagemTabuleiro { get => imagemTabuleiro; set => imagemTabuleiro = value; }
        public DateTime DtCriacao { get => dtCriacao; set => dtCriacao = value; }
        public string CorTematica { get => corTematica; set => corTematica = value; }
    }
}
