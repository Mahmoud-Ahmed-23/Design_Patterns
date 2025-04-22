using StrategyDP.With_No_DP;

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
		}
	}
}
