using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
	public class OrderDetail
	{
		public int id { get; set; }

		public int orderAIDI { get; set; }
		public int partAIDI { get; set; }
		public uint price { get; set; }
		public virtual Parts part { get; set; }
		public virtual Order order { get; set; }
	}
}
