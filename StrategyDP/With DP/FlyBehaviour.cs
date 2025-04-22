using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_DP
{
	public interface IFlyBehaviour
	{
		void Fly();
	}
	public class FlyWithNormalSpeed : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I'm flying with normal speed");
		}
	}
	public class FlyWithRocketPower : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I'm flying with rocket power");
		}
	}

	public class FlyNoWay : IFlyBehaviour
	{
		public void Fly()
		{
			Console.WriteLine("I can't fly");
		}
	}
}
