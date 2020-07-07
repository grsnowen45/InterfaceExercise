using System;
namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public bool IsElectric { get; set; }
        public string TrunkSize { get; set; }

        public bool HasLights { get; set; }
        public int WheelCount { get; set; }
        public string Condition { get; set; }
        public int CupHolders { get; set; }

        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }

    }
}
