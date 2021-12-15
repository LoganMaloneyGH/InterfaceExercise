using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            
            //Dot Notation Syntax
            var sedan1 = new Car(); 
            sedan1.Name = "Honda Accord";
            sedan1.NumberOfWheels = 4;
            sedan1.IsElectric = false;
            sedan1.CorpName = "BrandX";
            sedan1.Logo = " best brandX ever";
            sedan1.HasTrunk = true;

            //Object Initializer Sytnax
            var pickup = new Truck() { Name = "ford F-150", CorpName = "landscapers Inc", Logo = "trees", HasBed = true, HasHitch = true, NumberOfWheels = 4};

            var suv1 = new suv();
            suv1.Name = "jeep Wrangler";
            suv1.CorpName = "cool jeeps";
            suv1.Logo = "C00L J33PS";
            suv1.FWD = true;
            suv1.HasStereo = true;
            suv1.NumberOfWheels = 4;

            var carList = new List<iVehicle>() { suv1, pickup, sedan1 };
            var carList2 = new List<iCompany>() { suv1, pickup, sedan1 };
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"Vehcile {vehicle.GetType().Name} is called a {vehicle.Name}.");
                Console.WriteLine($"It has {vehicle.NumberOfWheels} wheels."); 
                foreach(var x in carList2)
                {
                    Console.WriteLine($"comapny Name: {x.CorpName}");
                    Console.WriteLine($"Company Logo: {x.Logo}"); 
                }
            }


            

        }
    }
}
