using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{
	public class Book
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Athure { get; set; }
		public string Genre { get; set; }
		public int ISBN { get; set; }
		public int Number { get; set; }
	}

	public class Borrowed_Book
	{
		public int Id { get; set; }
		public int Book_Id { get; set; }
		public DateTime GetDay { get; set; }
	}
}
