using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JdoCRUD.Model
{
    public class Skin
    {
        private int id;
        private string nomeSkin;
        private string imagemSkin;
        private bool ehPermanente;
        private int tipoPeca;
        private string corTematica;

        public int Id { get => id; set => id = value; }
        public string NomeSkin { get => nomeSkin; set => nomeSkin = value; }
        public string ImagemSkin { get => imagemSkin; set => imagemSkin = value; }
        public bool EhPermanente { get => ehPermanente; set => ehPermanente = value; }
        public int TipoPeca { get => tipoPeca; set => tipoPeca = value; }
        public string CorTematica { get => corTematica; set => corTematica = value; }

        public Skin()
        {

        }
    }
}
