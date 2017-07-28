using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Sushmita Nandalan
 * Student no: 300923159
 * Date: July 27th 2017
 * Description: This is the class TerrestrialPlanet which is a subclass of the Planet Abstract Class. 
 * Version: 0.1 - TerrestrialPlanet class created.
 */
namespace COMP123_S2017_Assignment4
{
	/// <summary>
	/// This is the TerrestrialPlanet class.
	/// </summary>
	class TerrestrialPlanet : Planet
	{
		//PRIVATE INSTANCE VARIABLES

		private bool _oxygen;

		//PUBLIC CONSTRUCTORS
		/// <summary>
		/// This is the constructor for the TerrestrialPlanet class
		/// It takes 4 arguments name (string), diameter(double), mass(double) and oxygen(bool).
		/// </summary>
		/// <param name="name"></param>
		/// <param name="diameter"></param>
		/// <param name="mass"></param>
		/// <param name="oxygen"></param>
		public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen) : base(name, diameter, mass)
		{
			this._oxygen = oxygen;
		}
	}
}
