using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class biblioteca
    {
        private string nome;
        private string indirizzo;
        private string apertura;
        private string chiusura;
         List<string> libri;

        public biblioteca(string nome, string indirizzo, string apertura, string chiusura, List<string> libri)
        {
            this.nome = nome;
            this.indirizzo = indirizzo;
            this.apertura = apertura;
            this.chiusura = chiusura;
            this.libri = libri;
        }
        public void addLibro(string nomeLibro)
        {
            libri.Add(nomeLibro); 
        }

        public int libriPresenti()
        {
            return libri.Count;
        }
    }
}
