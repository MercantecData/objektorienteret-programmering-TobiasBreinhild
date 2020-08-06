using System;
using AnsatLibrary;
using HoldLibrary;
using KursusLibrary;

namespace LokaleLibrary
{
    public class Lokale
    {
        Ansat lokaleAnsat = new Ansat();
        Hold lokaleHold = new Hold();
        Kursus lokaleKursus = new Kursus();

        int lokaleNr;

        public Lokale(Ansat lokaleAnsat, Hold lokaleHold, Kursus lokaleKursus, int lokaleNr)
        {
            this.lokaleAnsat = lokaleAnsat;
            this.lokaleHold = lokaleHold;
            this.lokaleKursus = lokaleKursus;
            this.lokaleNr = lokaleNr;
        }
    }
}
