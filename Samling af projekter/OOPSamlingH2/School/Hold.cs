using System;
using System.Collections.Generic;
using School;

namespace School
{
    public class Hold
    {
        public List<Elev> elevHold = new List<Elev>();

        public int holdNr;

        public Hold(List<Elev> elevHold, int holdNr)
        {
            this.elevHold = elevHold;
            this.holdNr = holdNr;
        }
    }
}
