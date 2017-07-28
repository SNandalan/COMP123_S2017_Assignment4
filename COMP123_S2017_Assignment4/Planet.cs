using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Name: Sushmita Nandalan
 * Student no: 300923159
 * Date: July 27th 2017
 * Description: This is the abstract class Planet
 * Version: 0.2 - Added units to the ToString Method.
 * Link: https://github.com/SNandalan/COMP123_S2017_Assignment4
 */
namespace COMP123_S2017_Assignment4
{
	class Planet
	{
		//PRIVATE INSTANCE VARIABLES

		private double _diameter;
		private double _mass;
		private int _moonCount;
		private string _name;
		private double _orbitalPeriod;
		private int _ringCount;
		private double _rotationPeriod;

		//PUBLIC PROPERTIES
		public double Diameter
		{
			get
			{
				return _diameter;
			}
		}

		public double Mass
		{
			get
			{
				return _mass;
			}
		}


		public int MoonCount
		{
			get
			{
				return _moonCount;
			}
			set
			{
				_moonCount = value;
			}
		}

		public string Name
		{
			get
			{
				return _name;
			}
		}

		public double OrbitalPeriod
		{
			get
			{
				return _orbitalPeriod;
			}
			set
			{
				_orbitalPeriod = value;
			}
		}

		public int RingCount
		{
			get
			{
				return _ringCount;
			}
			set
			{
				_ringCount = value;
			}
		}

		public double RotationPeriod
		{
			get
			{
				return _rotationPeriod;
			}
			set
			{
				_rotationPeriod = value;
			}
		}

		//PUBLIC CONSTRUCTORS

		/// <summary>
		/// This is the contructor for the abstract class Planet.
		/// It contains takes three arguments name(string), diameter(double) and mass(double).
		/// </summary>
		/// <param name="name"></param>
		/// <param name="diameter"></param>
		/// <param name="mass"></param>
		public Planet(string name, double diameter, double mass)
		{
			this._name = name;
			this._diameter = diameter;
			this._mass = mass;
		}

		/// <summary>
		/// This is the public override method for the Planet class
		/// It returns a string that displays the name, diameter and mass of the planets. 
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("Planet:{0}, Diameter:{1}km, Mass: {2}kg", Name, Diameter, Mass);

		}
	}
}
