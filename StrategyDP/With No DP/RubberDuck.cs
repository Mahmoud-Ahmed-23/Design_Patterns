using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_No_DP
{
	internal class RubberDuck : Duck
	{
		public override void Display()
		{
			Console.WriteLine("I'm a rubber duck");
		}
		public new void Quack()
		{
			Console.WriteLine("Squeak");
		}

		public new void Fly()
		{
			Console.WriteLine("No Wings To Fly");
		}
	}
}
