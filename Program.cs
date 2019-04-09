using System;

namespace Planner
{
    class Program
    {
 static void Main(string[] args)
        {
            // Create several buildings in the Main() method of Program.cs.
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building SuperTallBldg = new Building("123 Main St");
            Building CuteBrickStore = new Building("45 Small St");

            // Give each building a width, height, and number of stories.
            FiveOneTwoEigth.Width = 340;
            FiveOneTwoEigth.Depth = 33;
            FiveOneTwoEigth.Stories = 4;

            SuperTallBldg.Width = 32;
            SuperTallBldg.Depth = 332;
            SuperTallBldg.Stories = 100;

            CuteBrickStore.Width = 100;
            CuteBrickStore.Depth = 100;
            CuteBrickStore.Stories = 2;

            // Construct each building.
            FiveOneTwoEigth.Construct();
            SuperTallBldg.Construct();
            CuteBrickStore.Construct();

            // Have business people in your city purchase each of your buildings.
            FiveOneTwoEigth.Purchase("Joe Shmoe");
            SuperTallBldg.Purchase("Pete Bird");
            CuteBrickStore.Purchase("Kimmy Bird");

            /*
            After all of the buildings have been purchased, display the following information to the console for each building.

            100 Main Street
            ---------------
            Designed by Steve Brownlee
            Constructed on 2/1/18 7:19:08 AM
            Owned by Bob Ross
            16128 cubic meters of space
            */

/*          
This stuff won't work in Program.cs because it is accessing private fields  
            Console.WriteLine($@"
{FiveOneTwoEigth._address}
-------------------------
Designed by {FiveOneTwoEigth._designer}
Constructed on {FiveOneTwoEigth._dateConstructed}
Owned by {FiveOneTwoEigth._owner}
{FiveOneTwoEigth.Volume} cubic meters of space.");

            Console.WriteLine($@"
{SuperTallBldg._address}
-------------------------
Designed by {SuperTallBldg._designer}
Constructed on {SuperTallBldg._dateConstructed}
Owned by {SuperTallBldg._owner}
{SuperTallBldg.Volume} cubic meters of space.");

            Console.WriteLine($@"
{CuteBrickStore._address}
-------------------------
Designed by {CuteBrickStore._designer}
Constructed on {CuteBrickStore._dateConstructed}
Owned by {CuteBrickStore._owner}
{CuteBrickStore.Volume} cubic meters of space.");
 */

            // create new city instance
            City SLC = new City("Salt Lake City", 1800);

            // add buildings to city
            SLC.AddBuilding(FiveOneTwoEigth);
            SLC.AddBuilding(SuperTallBldg);
            SLC.AddBuilding(CuteBrickStore);

            foreach (Building bldg in SLC.AllBuildings)
            {
                Console.WriteLine(bldg);
            }

        }
    }
}
