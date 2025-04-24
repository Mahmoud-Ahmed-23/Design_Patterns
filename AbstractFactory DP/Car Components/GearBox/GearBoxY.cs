using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_DP.Car_Components.GearBox
{
	internal class GearBoxY : IGearBox
	{
		public int ShiftNumber => 5;
		public bool IsAutomatic => false;
	}
}
