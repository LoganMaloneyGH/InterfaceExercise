using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class suv : iVehicle, iCompany
    {
        public string Name { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set; }
        public string CorpName { get; set; }
        public string Logo { get; set; }

        public bool FWD { get; set; }
        public int CargoSpace { get; set; }
    }
}
