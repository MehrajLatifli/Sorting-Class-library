using Sorting;
using Sorting.Models;
using Sorts_object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();

            Sorts.AddList(numberList, 4);
            Sorts.AddList(numberList, 2);
            Sorts.AddList(numberList, 5);
            Sorts.AddList(numberList, 9);
            Sorts.AddList(numberList, 10);
            Sorts.AddList(numberList, 12);
            Sorts.AddList(numberList, 19);
            Sorts.AddList(numberList, 14);

            Sorts.showListNumber(numberList);

            Sorts.BubbleSortNumber(numberList);

            Sorts.showListNumber(numberList);


            var customerarray = new Customer[]{
              new Customer { Id = 1, Name = "Customer_1" },
              new Customer { Id = 3, Name = "Customer_3" },
              new Customer { Id = 2, Name = "Customer_2" },
              new Customer { Id = 6, Name = "Customer_6" },
              new Customer { Id = 4, Name = "Customer_4" },
              new Customer { Id = 5, Name = "Customer_5" }
             };

            Sort_object < Customer > sort_Object = new Sort_object<Customer>();

            sort_Object.BubleSort(customerarray);

            sort_Object.showArray(customerarray);

            Console.ReadKey();
        }
    }
}
