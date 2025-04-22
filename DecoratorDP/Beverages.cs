using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP
{
	abstract class Beverage
	{
		public virtual string Description { get; set; }
		public virtual decimal Cost { get; set; }
		public override string ToString()
		{
			return $"{Description} : {Cost:c}";
		}
	}

	class Espresso : Beverage
	{
		public Espresso()
		{
			Description = "Espresso";
			Cost = 1.99m;
		}
	}
	class HouseBlend : Beverage
	{
		public HouseBlend()
		{
			Description = "House Blend Coffee";
			Cost = 0.89m;
		}
	}
	class DarkRoast : Beverage
	{
		public DarkRoast()
		{
			Description = "Dark Roast Coffee";
			Cost = 0.99m;
		}
	}


}
