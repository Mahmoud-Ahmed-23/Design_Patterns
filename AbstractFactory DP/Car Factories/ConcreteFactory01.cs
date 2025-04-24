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
	internal class ConcreteFactory01 : IFactory
	{
		public IEngine Engine()
		=> new BMWEngine();

		public IFrontWing FrontWing()
		=> new DesignA();

		public IGearBox GearBox()
		=> new GearBoxX();
	}
}
