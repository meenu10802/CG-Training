using System;

namespace CGTraining.Day2
{
    public class VolumeOfEarth
    {
        public static void Calculate()
        {
            double radiusInKilometers = 6378;
            double piValue = 3.14159;
            double kilometerToMile = 0.621371;//because in both km and miles it has been asked
            double volumeInCubicKilometers=(4.0 / 3.0) * piValue * radiusInKilometers * radiusInKilometers * radiusInKilometers;
            double radiusInMiles = radiusInKilometers * kilometerToMile;
            double volumeInCubicMiles = (4.0 / 3.0) * piValue * radiusInMiles * radiusInMiles * radiusInMiles;
            Console.WriteLine(
                "The volume of earth in cubic kilometers is " + volumeInCubicKilometers +
                " and cubic miles is " + volumeInCubicMiles
            );
        }
    }
}