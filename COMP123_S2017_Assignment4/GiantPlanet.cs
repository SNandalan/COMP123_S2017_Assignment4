using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Sushmita Nandalan
 * Student no: 300923159
 * Date: July 27th 2017
 * Description: This is the class GiantPlanet which is a subclass of the Planet Abstract Class. 
 * Version: 0.2 - Added the methods HasMoons() and HasRings() to GiantPlanet class. 
 */
namespace COMP123_S2017_Assignment4
{
	/// <summary>
	/// This is the GiantPlanet class.
	/// </summary>
	class GiantPlanet : Planet
	{
		//PRIVATE INSTANCE VARIABLES

		private string _type;

		//PUBLIC CONSTRUCTORS
		/// <summary>
		/// This is the contructor for the GiantPlanet class.
		/// It takes 4 arguments name (string), diameter(double), mass(double) and type(string).
		/// </summary>
		/// <param name="name"></param>
		/// <param name="diameter"></param>
		/// <param name="mass"></param>
		/// <param name="type"></param>
		public GiantPlanet(string name, double diameter, double mass, string type) : base(name, diameter, mass)
		{
			this._type = type;
		}

		//PUBLIC METHODS

		/// <summary>
		/// This is the HasMoons method.
		/// </summary>
		/// <returns> Returns true if the MoonCount property is greater than zero. </returns>
		public bool HasMoons()
		{
			return (MoonCount > 0);
		}

		/// <summary>
		/// This is the HasRings method.
		/// </summary>
		/// <returns> Returns true if the RingCount property is greater than zero. </returns>
		public bool HasRings()
		{
			return (RingCount > 0);
		}

	}
}
