using System;
using System.Collections.Generic;
using School;

namespace School
{
    public class Ansat
    {
        Hold ansatHold = new Hold(new List<Elev>(), 69);
        Kursus ansatKursus = new Kursus(4, "DET VIRKER");
        bool løn;

        public Ansat(Hold ansatHold, Kursus ansatKursus, bool løn)
        {
            this.ansatHold = ansatHold;
            this.ansatKursus = ansatKursus;
            this.løn = løn;
        }
    }
}
