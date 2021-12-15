using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : iVehicle, iCompany
    {
        public string Name { get; set; }
        public int NumberOfWheels { get; set; }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set; }
        public string CorpName { get; set; }
        public string Logo { get; set; }

        public bool HasHitch { get; set; }
        public bool HasBed { get; set; }

    }
}
