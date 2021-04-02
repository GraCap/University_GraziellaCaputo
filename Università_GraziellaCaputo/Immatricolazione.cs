using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Università_GraziellaCaputo
{
    class Immatricolazione
    {
        private static int _matricola = 0;
        public int Matricola { get; set; }
        public DateTime DataInizio { get; set; }

        private CorsoDiLaurea _corsoDiLaurea;
        public bool FuoriCorso { get; set; } //si potrebbe implementare un metodo che confronti anno di imm con quello corrente stabilendo se lo studente è fuoricorso o meno
        public int CFUAccumulati { get; set; } //si aggiornano a ogni esame superato

        private Studente _studente;
        public string Info => $"Matricola: {Matricola} Data inizio: {DataInizio.ToShortDateString()} Fuoricorso: {FuoriCorso} CFU: {CFUAccumulati}.";

        public Immatricolazione(DateTime dataInizio, CorsoDiLaurea corsoDiLaurea)
        {
            Matricola = ++_matricola;
            DataInizio = dataInizio;
            _corsoDiLaurea = corsoDiLaurea;
        }

        public void Immatr(Studente s) //la utilizzo nel costruttore dello studente per poter dar luogo alla relazione studente-immatricolazione
        {
            _studente = s;
        }

        public CorsoDiLaurea CorsoDiLaureaAssociatoAlloStudente
        {
            get
            {
                return _corsoDiLaurea;
            }
        }


    }
}