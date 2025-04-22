using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_No_DP
{
	internal class RealDuck : Duck
	{
		public override void Display()
		{
			Console.WriteLine("I'm a real duck");
		}

		public new void Quack()
		{
			Console.WriteLine("Quack");
		}

		public new void Fly()
		{
			Console.WriteLine("I'm flying!");
		}
	}
}
