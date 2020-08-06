using System;
using System.Collections.Generic;
using ElevLibrary;

namespace HoldLibrary
{
    public class Hold
    {
        public List<Elev> elevHold1 = new List<Elev>();
        public List<Elev> elevHold2 = new List<Elev>();
        public List<Elev> elevHold3 = new List<Elev>();

        int holdNr;

        public Hold(List<Elev> elevHold1, List<Elev> elevHold2, List<Elev> elevHold3, int holdNr)
        {
            this.elevHold1 = elevHold1;
            this.elevHold2 = elevHold2;
            this.elevHold3 = elevHold3;
            this.holdNr = holdNr;
        }
    }
}
