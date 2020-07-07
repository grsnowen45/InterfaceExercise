using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool Offroad { get; set; }
        public string TruckBedSize { get; set; }

        public bool HasLights { get; set; }
        public int WheelCount { get; set; }
        public string Condition { get; set; }
        public int CupHolders { get; set; }

        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }

    }


}
