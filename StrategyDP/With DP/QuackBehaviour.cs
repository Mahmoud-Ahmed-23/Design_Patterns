using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_DP
{
	public interface IQuackBehaviour
	{
		void Quack();
	}

	internal class NormalQuack : IQuackBehaviour
	{
		public void Quack()
		{
			Console.WriteLine("Quack");
		}
	}

	internal class Squeak : IQuackBehaviour
	{
		public void Quack()
		{
			Console.WriteLine("Squeak");
		}
	}
}
