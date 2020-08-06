using System;
using HoldLibrary;
using KursusLibrary;

namespace AnsatLibrary
{
    public class Ansat
    {
        Hold ansatHold = new Hold();
        Kursus ansatKursus = new Kursus();
        bool løn;

        public Ansat(Hold ansatHold, Kursus ansatKursus, bool løn)
        {
            this.ansatHold = ansatHold;
            this.ansatKursus = ansatKursus;
            this.løn = løn;
        }
    }
}
