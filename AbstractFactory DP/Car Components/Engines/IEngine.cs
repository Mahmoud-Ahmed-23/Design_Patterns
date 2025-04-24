using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Car_Components.Engines
{
	public interface IEngine
	{
		public int HoursePower { get; }
		public int MaxSpeed { get; }

	}
}
