using System;
using System.Collections.Generic;
using School;

namespace School
{
    public class Lokale
    {
        public Ansat lokaleAnsat = new Ansat(new Hold(new List<Elev>(), 69), new Kursus(4, "DET VIRKER"), true);
        public Hold lokaleHold = new Hold(new List<Elev>(), 69);
        public Kursus lokaleKursus = new Kursus(4, "DET VIRKER");

        public int lokaleNr;

        public Lokale(Ansat lokaleAnsat, Hold lokaleHold, Kursus lokaleKursus, int lokaleNr)
        {
            this.lokaleAnsat = lokaleAnsat;
            this.lokaleHold = lokaleHold;
            this.lokaleKursus = lokaleKursus;
            this.lokaleNr = lokaleNr;
        }
    }
}