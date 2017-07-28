using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Sushmita Nandalan
 * Student no: 300923159
 * Date: July 28th 2017
 * Description: This is the class TerrestrialPlanet which is a subclass of the Planet Abstract Class. 
 * Version: 0.3 - Implemented IHasMoons and IHabitable interfaces 
 */
namespace COMP123_S2017_Assignment4
{
	/// <summary>
	/// This is the TerrestrialPlanet class.
	/// </summary>
	class TerrestrialPlanet : Planet, IHasMoons, IHabitable
	{
		//PRIVATE INSTANCE VARIABLES

		private bool _oxygen;

        //PUBLIC PROPERTIES
        public bool Oxygen
        {
            get
            {
                return _oxygen;
            }
            set
            {
                _oxygen = value;
            }
        }

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
		/// This is the Habitable method.
		/// </summary>
		/// <returns> Returns true if the _oxygen instance variable is set to true. </returns>
		public bool Habitable()
		{
			return _oxygen;
		}
	}
}
