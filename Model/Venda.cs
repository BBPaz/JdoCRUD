using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdoCRUD.Model
{
    public class Venda
    {
        private int id;
        private decimal valor;
        private int idSeason;
        private int idSkin;

        public int Id { get => id; set => id = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public int IdSeason { get => idSeason; set => idSeason = value; }
        public int IdSkin { get => idSkin; set => idSkin = value; }
    }
}
