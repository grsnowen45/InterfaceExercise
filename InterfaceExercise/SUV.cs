using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string CargoHold { get; set; }
        public bool DvdPlayer { get; set; }

        public bool HasLights { get; set; }
        public int WheelCount { get; set; }
        public string Condition { get; set; }
        public int CupHolders { get; set; }

        public string CompanyName { get; set; }
        public string CompanyLocation { get; set; }





    }

}
