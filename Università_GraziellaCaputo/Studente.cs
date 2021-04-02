using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Università_GraziellaCaputo
{
    class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoDiNascita { get; set; }

        private Immatricolazione _immatricolazione;

        private List<Esame> _esami = new List<Esame>();
        private bool RichiestaLaurea = false;

        public Esame esameRichiesto;

        public Studente(string nome, string cognome, int annoDiNascita, Immatricolazione im)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoDiNascita = annoDiNascita;
            _immatricolazione = im;         
            _immatricolazione.Immatr(this); //creo una corrispondenza tra il singolo studente e la singola immatricolazione

        }


        public string InfoImmatricolazione
        {
            get
            {
                string s = "";
                    s = _immatricolazione.Info ;        
                return s;
            }
        }

        //Non riesco ad aggiungere un esame. Non trova corrispondenze!!?? 
        public Esame RichiestaEsame(string esame, int cfu)      
        {
            /*prima di aggiungerlo agli esami dello studente verifico che sia presente nell'elenco di esami associati al corso di laurea 
                                             a cui risulta iscritto e poi che siano rispettati i vincoli di cfu e ancora non abbia richiesto la laurea*/
            if (_immatricolazione.CorsoDiLaureaAssociatoAlloStudente.EsameInLista(esame) &&
                cfu <= _immatricolazione.CorsoDiLaureaAssociatoAlloStudente.CFU &&
                 RichiestaLaurea != true)
            {
                esameRichiesto = new Esame(esame, cfu);
                _esami.Add(esameRichiesto);
            }
            else
            {
                throw new ArgumentException("L'esame inserito non rispetta i requisiti.");
            }
            return esameRichiesto;
        }


        public void EsameSuperato(Esame e)
        {
            //aggiorno i dati universitari in caso di esito positivo
            _immatricolazione.CFUAccumulati += e.CFU;
            e.Superato = true;

            if (_immatricolazione.CFUAccumulati == _immatricolazione.CorsoDiLaureaAssociatoAlloStudente.CFU)
            {
                RichiestaLaurea = true;
            }
        }
    }

}