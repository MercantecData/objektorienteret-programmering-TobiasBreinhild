using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            var stringDiction = new Dictionary<string, int>();

            stringDiction["Hej1"] = 1;
            stringDiction["Hej2"] = 2;
            stringDiction["Hej3"] = 3;
            stringDiction["Hej4"] = 4;
            stringDiction["Hej5"] = 5;
            stringDiction["Hej6"] = 6;
            stringDiction["Hej7"] = 7;
            stringDiction["Hej8"] = 8;
            stringDiction["Hej9"] = 9;
            stringDiction["Hej10"] = 10;

            var boolDiction = new Dictionary<float, bool>(); //Dictionary

            boolDiction[1.15f] = false;
            boolDiction[2.3f] = false;
            boolDiction[3.45f] = false;
            boolDiction[4.6f] = false;
            boolDiction[5.75f] = false;
            boolDiction[6.9f] = true;
            boolDiction[8.05f] = false;
            boolDiction[9.2f] = false;
            boolDiction[10.35f] = false;
            boolDiction[11.5f] = false;
        }
    }
}
