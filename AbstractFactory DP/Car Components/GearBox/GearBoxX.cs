using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Car_Components.GearBox
{
	internal class GearBoxX : IGearBox
	{
		public int ShiftNumber => 6;

		public bool IsAutomatic => false;
	}
}
