using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
   public interface iVehicle
    {

        public string Name { get; set;  }
        public int NumberOfWheels { get; set;  }
        public bool HasStereo { get; set; }
        public bool HasSunRoof { get; set;  }


    }
}
