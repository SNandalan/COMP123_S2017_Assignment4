using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Sushmita Nandalan
 * Student no: 300923159
 * Date: July 28th 2017
 * Description: This is the driver class for the project
 * Version: 0.1 - Planet class created
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
            GiantPlanet gPlanet1 = new GiantPlanet("Jupiter", 139822, 1.898, "Gas");
            GiantPlanet gPlanet2 = new GiantPlanet("Neptune", 49244, 1.024, "Ice");
            TerrestrialPlanet tPlanet1 = new TerrestrialPlanet("Earth", 12742, 5.972, true);
            TerrestrialPlanet tPlanet2 = new TerrestrialPlanet("Venus", 12104, 4.867, false);

            Console.WriteLine("Giant Planets\n");
            Console.WriteLine(gPlanet1.ToString());
            Console.WriteLine(gPlanet2.ToString());

            Console.WriteLine("Terrestrial Planets\n");
            Console.WriteLine(tPlanet1.ToString());
            Console.WriteLine(tPlanet2.ToString());
        }
        /// <summary>
        /// This is the WaitForAnyKey() method
        /// It reads the console for any key press before it closes. 
        /// </summary>
        public static void WaitForAnyKey()
        {
            Console.Write("Press any key to exit");
            Console.ReadKey();
        }
    }
}
