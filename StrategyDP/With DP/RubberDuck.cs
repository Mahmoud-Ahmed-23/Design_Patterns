using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_DP
{
	internal class RubberDuck : Duck
	{

		public RubberDuck()
			: base(new FlyNoWay(), new Squeak())
		{

		}
		public override void Display()
		{
			Console.WriteLine("I'm a rubber duck");
		}

	}
}
