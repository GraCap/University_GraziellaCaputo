using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Università_GraziellaCaputo
{
    class Esame
    {
        public bool Superato = false;
        public string NomeEsame { get; set; }
        public int CFU { get; set; }
        private Corso _corso;

        public Esame(string nomeEsame, int cfu)
        {
            NomeEsame = nomeEsame;
            CFU = cfu;
        }

        public Corso CorsoAssociatoAllEsame
        {
            get { return _corso; }
        }

       
    }
}