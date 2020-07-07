using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public bool HasLights { get; set; }

        public int WheelCount { get; set; }

        public string Condition { get; set; }

        public int CupHolders { get; set; }


    }
}
