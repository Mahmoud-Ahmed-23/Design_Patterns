using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Car_Components.Engines
{
	internal class BMWEngine:IEngine
	{
		public int HoursePower => 2500;
		public int MaxSpeed => 300;
	}
}
