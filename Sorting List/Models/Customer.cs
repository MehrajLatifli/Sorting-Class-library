using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting.Models
{
	public class Customer : IComparable<Customer>
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public int CompareTo(Customer other)
		{
			return this.Id.CompareTo(other.Id);
		}

        public override string ToString()
        {
			return Id + " " + Name;
        }
    }
}
