using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Università_GraziellaCaputo
{
    class Corso
    {
        public string NomeCorso { get; set; }
        public int CFU { get; set; }
        public string Elenco => $"Corso: {NomeCorso} CFU: {CFU}.";

        public Corso(string nomeCorso, int cfu)
        {
            NomeCorso = nomeCorso;
            CFU = cfu;
        }

    }
}