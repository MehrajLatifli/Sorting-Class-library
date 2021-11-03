using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorts_object
{
    public class Sort_object<T> where T : IComparable<T>
	{
		public void BubleSort(T[] items)
		{

			for (int i = 0; i < items.Length; i++)
			{
				for (int j = 0; j < items.Length - 1 - i; j++)
				{
					if (items[j].CompareTo(items[j + 1]) > 0)
					{

						var temp = items[j];
						items[j] = items[j + 1];
						items[j + 1] = temp;
					}
				}
			}
		}

		public void showArray(T[] items)
		{
			Console.WriteLine("\n");
			foreach (var item in items)
			{
				Console.Write($" {item} \n");
			}
		}
	}
}
