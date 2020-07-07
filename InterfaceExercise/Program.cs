using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //done Create 2 Interfaces called IVehicle & ICompany

            //done Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /*done Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*done Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*done Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * done Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //done Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var car = new Car()
            {
                CompanyName = "Honda",
                CompanyLocation = "Japan",
                HasLights = true,
                WheelCount = 4,
                Condition = "Decent",
                CupHolders = 12,

                IsElectric = true,
                TrunkSize = "very small"


            };

            var truck = new Truck()
            {
                CompanyName = "Ford",
                CompanyLocation = "USA",
                HasLights = true,
                WheelCount = 4,
                Condition = "Dadgum Guud",
                CupHolders = 0,

                Offroad = true,
                TruckBedSize = "Hyuuuuge!!"
            };


            var suv = new SUV()
            {
                CompanyName = "BMW",
                CompanyLocation = "Germany",
                HasLights = true,
                WheelCount = 4,
                Condition = "Always Breaking",
                CupHolders = 4,

                CargoHold = "Lots of space!",
                DvdPlayer = true
            };



            var carlist = new List<IVehicle>() { car, truck, suv };

            foreach(var veh in carlist)
            {

                Console.WriteLine($"Type:{veh.GetType().Name}" +
                    $" Condition: {veh.Condition}" +
                    $"Lights: {veh.HasLights}" +
                    $"Wheel Count: {veh.WheelCount}" +
                    $"Cupholders: {veh.CupHolders}");
                Console.WriteLine("");

            }


















        }
    }
}
