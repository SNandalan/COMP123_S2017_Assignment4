using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Sushmita Nandalan
 * Student no: 300923159
 * Date: July 28th 2017
 * Description: This is the IHasMoons interface that is implemented by the GiantPlant class and TerrestrialPlanet class.
 * Version: 0.1 - IHasMoons interface created. 
 */
namespace COMP123_S2017_Assignment4
{
	/// <summary>
	/// This is the IHasMoons interface.
	/// </summary>
	public interface IHasMoons
	{
		/// <summary>
		/// This is the HasMoons method.
		/// </summary>
		/// <returns>It returns a bool data type</returns>
		bool HasMoons();
	}
}
