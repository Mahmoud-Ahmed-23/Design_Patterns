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
	internal interface IFactory
	{
		public IEngine Engine();
		public IGearBox GearBox();
		public IFrontWing FrontWing();
	}
}
