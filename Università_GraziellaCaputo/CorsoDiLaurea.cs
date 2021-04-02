using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Università_GraziellaCaputo
{
    class CorsoDiLaurea
    {
        public string Nome { get; set; }
        public int AnnoDiCorso { get; set; }
        public int CFU { get; set; }

        private List<Corso> _corsi = new List<Corso>();

        public CorsoDiLaurea(string nome, int annoDiCorso, int cfu, params Corso[] corsi)
        {
            Nome = nome;
            AnnoDiCorso = annoDiCorso;
            CFU = cfu;

            foreach (Corso c in corsi)      //aggiungo i corsi alla lista
                _corsi.Add(c);

        }

        public string ElencoCorsi
        {
            get
            {
                string s = "";
                foreach (Corso c in _corsi)
                    s += c.Elenco + '\n';       //mostra l'elenco di corsi di un singolo corso di laurea
                return s;
            }
        }

        public bool EsameInLista(string esame)      //cerca all'interno del corso di laurea l'effettiva presenza del corso di cui si vuole sostenere l'esame
        {
            bool esamePresenteInCorso = false;
            foreach (Corso c in _corsi)
            {
                if (c.NomeCorso == esame)   //il parametro esame da sostenere corrisponde al nome del corso
                    return esamePresenteInCorso = true;
                else return esamePresenteInCorso = false;
            }
            return esamePresenteInCorso;
        }

       //forse avrei potuto implementare una funzione di ricerca con tipo di ritorno Esame in modo da utilizzarla nel metodo Richiesta Esame 
        //controllando anche i cfu del corso 
       //invece che passarli come parametri d'ingresso nella chiamata dal main.. non saprei
    }
}