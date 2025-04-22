using StrategyDP.With_DP;

namespace StrategyDP
{
	internal class Program
	{
		static void Main(string[] args)
		{

			RealDuck realDuck = new RealDuck();
			realDuck.Display();
			realDuck.Fly(() => Console.WriteLine("I'm flying with normal speed"));
			realDuck.Quack(() => Console.WriteLine("Quack"));
			realDuck.Swim();

			Console.WriteLine("====================================");

			RubberDuck rubberDuck = new RubberDuck();
			rubberDuck.Display();
			rubberDuck.Fly(() => Console.WriteLine("I can't fly"));
			rubberDuck.Quack(() => Console.WriteLine("Squeak"));
			rubberDuck.Swim();

			Console.WriteLine("====================================");
			// Changing the behaviour of the duck at runtime

			realDuck.FlyBehaviour = new FlyWithRocketPower();
			realDuck.QuackBehaviour = new NormalQuack();
			realDuck.Fly(() => Console.WriteLine("I'm flying with rocket power"));
			realDuck.Quack(() => Console.WriteLine("Quack"));
		}
	}
}
