using AbstractFactory_DP.Car_Factories;

namespace AbstractFactory_DP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IFactory factory = new ConcreteFactory01();

			//factory = new ConcereteFactory02();

			F1CarClient f1CarClient = new F1CarClient(factory);

			f1CarClient.CreateCar();
		}
	}
}
