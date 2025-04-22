using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_DP
{
	internal class RealDuck : Duck
	{
		public RealDuck()
			: base(new FlyWithNormalSpeed(), new NormalQuack())
		{
		}
		public override void Display()
		{
			Console.WriteLine("I'm a real duck");
		}
	}
}
