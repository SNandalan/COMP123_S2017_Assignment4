using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Sushmita Nandalan
 * Student no: 300923159
 * Date: July 28th 2017
 * Description: This is the driver class for the project
 * Version: 0.2 - Used the HasMoons, HasRings and Habitable methods. 
 * Link: https://github.com/SNandalan/COMP123_S2017_Assignment4
 */
namespace COMP123_S2017_Assignment4
{
    /// <summary>
    /// Driver class for planets
    /// </summary>
	class Program
	{
		static void Main(string[] args)
		{
            //creating objects
            GiantPlanet gPlanet1 = new GiantPlanet("Jupiter", 139822, 1.898 * Math.Pow(10, 24), "Gas");
            GiantPlanet gPlanet2 = new GiantPlanet("Neptune", 49244, 1.024 * Math.Pow(10, 27), "Ice");
            TerrestrialPlanet tPlanet1 = new TerrestrialPlanet("Earth", 12742, 5.972 * Math.Pow(10, 26), true);
            TerrestrialPlanet tPlanet2 = new TerrestrialPlanet("Venus", 12104, 4.867 * Math.Pow(10, 24), false);

            Console.WriteLine("Giant Planets\n");
            Console.WriteLine(gPlanet1.ToString());
            gPlanet1.MoonCount = 2;
            Console.WriteLine("HasMoons: {0}", gPlanet1.HasMoons());
            Console.WriteLine(gPlanet2.ToString());
            gPlanet2.RingCount = 4;
            Console.WriteLine("HasRings: {0}\n", gPlanet1.HasRings());

            Console.WriteLine("Terrestrial Planets\n");
            Console.WriteLine(tPlanet1.ToString());
            tPlanet1.Oxygen = true;
            Console.WriteLine("Habitable: {0}", tPlanet1.Habitable());
            Console.WriteLine(tPlanet2.ToString());
            tPlanet2.MoonCount = 0;
            Console.WriteLine("HasMoons: {0}", tPlanet2.HasMoons());

            WaitForAnyKey();
        }
        /// <summary>
        /// This is the WaitForAnyKey() method
        /// It reads the console for any key press before it closes. 
        /// </summary>
        public static void WaitForAnyKey()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
