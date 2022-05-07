using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdoCRUD.Model
{
    public class Season
    {
        private int id;
        private string nomeSeason;
        private DateTime inicioVigencia;
        private DateTime fimVigencia;
        private int idTabuleiro;

        public int Id { get => id; set => id = value; }
        public string NomeSeason { get => nomeSeason; set => nomeSeason = value; }
        public DateTime InicioVigencia { get => inicioVigencia; set => inicioVigencia = value; }
        public DateTime FimVigencia { get => fimVigencia; set => fimVigencia = value; }
        public int IdTabuleiro { get => idTabuleiro; set => idTabuleiro = value; }
    }
}
