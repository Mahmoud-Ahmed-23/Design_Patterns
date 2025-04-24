using AbstractFactory_DP.Car_Components.Engines;
using AbstractFactory_DP.Car_Components.Front_Wings;
using AbstractFactory_DP.Car_Components.GearBox;
using AbstractFactory_DP.Car_Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP
{
	internal class F1CarClient
	{
		private IFactory _factory;

		private IEngine _engine;
		private IGearBox _gearBox;
		private IFrontWing _frontWing;

		public F1CarClient(IFactory factory)
		{
			_factory = factory;
		}
		virtual public void CreateCar()
		{
			_engine = _factory.Engine();
			_gearBox = _factory.GearBox();
			_frontWing = _factory.FrontWing();
		}

	}
}
