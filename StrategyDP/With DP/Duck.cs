using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_DP
{
	public abstract class Duck
	{
		public abstract void Display();

		public IQuackBehaviour QuackBehaviour { get; set; }
		public IFlyBehaviour FlyBehaviour { get; set; }

		protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
		{
			FlyBehaviour = flyBehaviour;
			QuackBehaviour = quackBehaviour;
		}
		public void Quack(Action quackAction)
		{
			quackAction.Invoke();
		}

		public void Swim()
		{
			Console.WriteLine("All ducks float, even decoys!");
		}

		public void Fly(Action flyAction)
		{
			flyAction.Invoke();
		}

	}
}
