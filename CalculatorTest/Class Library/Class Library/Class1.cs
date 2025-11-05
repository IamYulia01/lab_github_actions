using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library
{
	public class CMass
	{
		private int[] mass;
		// конструкторы
		public CMass(int lengh)
		{
			mass = new int[lengh];
		}
		public CMass(int[] massValue)
		{
			mass = new int[massValue.Length];
			mass = massValue;
		}
		// свойство определения длины массива
		public int getLenghMass
		{
			get { return mass.Length; }
		}


		// индексатор
		public int this[int i]
		{
			get { return mass[i]; }
			set { mass[i] = value; }
		}

		public static int Sum(params CMass[] numbers)
		{
			int result = 0;
			foreach (CMass mass in numbers)
			{
				for (int i = 0; i < mass.getLenghMass; i++)
				{
					if (mass[i] < 0) result += mass[i];
				}
			}
			return result;
		}
		

		public static int sumMass(int primary, int lastThing, CMass mass)
		{
			int composit = 0;
			bool isComposit = false;
			for (int i = primary - 1; i <= lastThing - 1; i++)
			{
				composit += mass[i];
				isComposit = true;
			}
			if (isComposit) return composit; else return 0;
		}
	}
}
