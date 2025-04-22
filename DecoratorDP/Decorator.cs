using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
	abstract class Decorator : Beverage
	{
		private protected Beverage _beverage;
		public Decorator(Beverage beverage)
		{
			_beverage = beverage;
		}
	}

	class Milk : Decorator
	{

		public Milk(Beverage beverage) : base(beverage)
		{
		}
		public override string Description => $"{_beverage.Description}, Milk";

		public override decimal Cost => _beverage.Cost + 0.10m;
	}

	class Mocha : Decorator
	{
		public Mocha(Beverage beverage) : base(beverage)
		{
		}
		public override string Description => $"{_beverage.Description}, Mocha";
		public override decimal Cost => _beverage.Cost + 0.20m;
	}

	class Caramel : Decorator
	{
		public Caramel(Beverage beverage) : base(beverage)
		{
		}
		public override string Description => $"{_beverage.Description}, Caramel";
		public override decimal Cost => _beverage.Cost + 0.30m;
	}
}
