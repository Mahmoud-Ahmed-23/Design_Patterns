using AbstractFactory_DP.Car_Components.Engines;
using AbstractFactory_DP.Car_Components.Front_Wings;
using AbstractFactory_DP.Car_Components.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Car_Factories
{
	internal class ConcereteFactory02 : IFactory
	{
		public IEngine Engine()
		=> new MercedesEngine();
		public IFrontWing FrontWing()
		=> new DesignB();
		public IGearBox GearBox()
		=> new GearBoxY();
	}
}
