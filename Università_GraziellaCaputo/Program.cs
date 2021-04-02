using System;

namespace Università_GraziellaCaputo
{
    class Program
    {
        static void Main(string[] args)
        {
            Corso a1 = new Corso("Analisi 1", 9); 
            Corso ce = new Corso("Calcolatori elettronici", 9);
            Corso ga = new Corso("Geometria e Algebra", 9);
            Corso is1 = new Corso("Ingegneria del software", 9);
            Corso so = new Corso("Sistemi Operativi", 9);

            CorsoDiLaurea ingegneria = new CorsoDiLaurea("Ingegneria", 2010, 180, a1, ce, ga, is1, so);

            Corso mq = new Corso("Meccanica quantistica", 9);
            Corso fn = new Corso("Fisica Nucleare", 9);
            Corso r = new Corso("Relatività", 6);
            Corso lab = new Corso("Laboratorio", 10);
            Corso c = new Corso("Chimica", 9);

            CorsoDiLaurea fisica = new CorsoDiLaurea("Fisica", 2008, 200, mq, fn, r, lab, c);

            Immatricolazione imm1 = new Immatricolazione(new DateTime(2019, 04, 14), ingegneria);
            Immatricolazione imm2 = new Immatricolazione(new DateTime(2005, 03, 09), fisica);


            Studente stud1 = new Studente("Gustave", "Eiffel", 1832, imm1);
            Studente stud2 = new Studente("Albert","Einstein", 1879, imm2);

            Esame e1 = stud1.RichiestaEsame("Geometria e Algebra", 9);
            stud1.EsameSuperato(e1);

            Esame e2 = stud2.RichiestaEsame("Laboratorio", 200);
            stud2.EsameSuperato(e2);

        }
    }
}
