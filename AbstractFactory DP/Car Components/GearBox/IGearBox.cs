using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Car_Components.GearBox
{
	internal interface IGearBox
	{
		public int ShiftNumber { get; }
		public bool IsAutomatic { get; }
	}
}
