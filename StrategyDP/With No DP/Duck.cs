using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_No_DP
{
	public abstract class Duck
	{
		public abstract void Display();
		
		public void Quack()
		{
			Console.WriteLine("Quack");
		}
		
		public void Swim()
		{
			Console.WriteLine("All ducks float, even decoys!");
		}

		public void Fly()
		{
			Console.WriteLine("I'm flying!");
		}

	}
}
