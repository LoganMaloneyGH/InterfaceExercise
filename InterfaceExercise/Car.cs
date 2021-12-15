using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : iVehicle, iCompany
    {
        public string Name { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set; }
        public string CorpName { get; set; }
        public string Logo { get; set; }

        public bool HasTrunk { get; set; }
        public bool IsElectric { get; set; }


    }
}
