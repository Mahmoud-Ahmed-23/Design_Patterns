namespace DecoratorDP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Beverage beverage = new Espresso();
			Console.WriteLine(beverage);
			Console.WriteLine("======================================");

			beverage = new Milk(beverage);
			Console.WriteLine(beverage);
			Console.WriteLine("======================================");

			beverage = new Mocha(beverage);
			Console.WriteLine(beverage);
			Console.WriteLine("======================================");

			beverage = new Caramel(beverage);
			Console.WriteLine(beverage);
			Console.WriteLine("======================================");

			Beverage beverage2 = new HouseBlend();
			Console.WriteLine(beverage2);
			Console.WriteLine("======================================");

			beverage2 = new Milk(beverage2);
			Console.WriteLine(beverage2);
			Console.WriteLine("======================================");

			beverage2 = new Mocha(beverage2);
			Console.WriteLine(beverage2);
			Console.WriteLine("======================================");
		}
	}
}
