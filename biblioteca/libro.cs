using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    internal class libro
    {
        private string autore;
        private string titolo;
        private int annoPubl;
        private string editore;
        private int nPagine;
        public libro(string autore, string titolo, int annoPubl, string editore, int nPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annoPubl = annoPubl;
            this.editore = editore;
            this.nPagine = nPagine;
        }
        public void modificaAutore(string nAutore) 
        { 
            autore = nAutore; 
        }
        public void modificaTitolo(string ntitolo)
        {
            titolo = ntitolo;
        }
        public void modificaAnnoPubl(int nAnnoPubl)
        {
            annoPubl = nAnnoPubl;
        }
        public void modificaEditore(string nEditore)
        {
            editore = nEditore;
        }
        public void modificaNPagine(int nNPagine)
        {
            nPagine = nNPagine;
        }
        public string toString()
        {
            return autore + " " + titolo + " " + annoPubl + " " + editore + " " + nPagine;
        }
        public string readingTime()
        {
            if (nPagine < 100)
            {
                return "tempo di lettura 1h";
            }
            else if (nPagine >= 100 && nPagine <= 200)
            {
                return "tempo di lettura 2h";
            }
            else
            {
                return "tempo di letture maggiore a 2h";
            }
        }
        
    }
}
