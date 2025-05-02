using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace A_Waddell_Lab_3
{
    public class State // make it public so the other files can access it and such
    {
        // get set because thats just statndrd procedure
        public string StateName { get; set; }
        public string FlagDesc { get; set; }
        public string StateFlower { get; set; }
        public string StateBird { get; set; }
        public string StateColors { get; set; }
        public string LargeCityOne { get; set; }
        public string LargeCityTwo { get; set; }
        public string LargeCityThree { get; set; }
        public string Capital { get; set; }
        public int MedIncom { get; set; }
        public int CompJobs { get; set; }

        // constructor
        public State(string name, string fDesc, string flower, string bird, string colors,
            string largeOne, string largeTwo, string largeThree, string capital, int medInc, int compJobs)
        {
            StateName = name;
            FlagDesc = fDesc;
            StateFlower = flower;
            StateBird = bird;
            StateColors = colors;
            LargeCityOne = largeOne;
            LargeCityTwo = largeTwo;
            LargeCityThree = largeThree;
            Capital = capital;
            MedIncom = medInc;
            CompJobs = compJobs;
        }
    }
}
