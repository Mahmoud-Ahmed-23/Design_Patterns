using StrategyDP.With_DP;

namespace StrategyDP
{
	internal class Program
	{
		static void Main(string[] args)
		{

			RealDuck realDuck = new RealDuck();
			realDuck.Display();
			realDuck.Fly();
			realDuck.Quack();
			realDuck.Swim();

			Console.WriteLine("====================================");

			RubberDuck rubberDuck = new RubberDuck();
			rubberDuck.Display();
			rubberDuck.Fly();
			rubberDuck.Quack();
			rubberDuck.Swim();

			Console.WriteLine("====================================");
			// Changing the behaviour of the duck at runtime

			realDuck.FlyBehaviour = new FlyWithRocketPower();
			realDuck.QuackBehaviour = new NormalQuack();
			realDuck.Fly();
			realDuck.Quack();
		}
	}
}
