using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Classes
{

	public enum Person_Type {Manager,Employee,User}
	public class Person
	{
		public Person_Type person_type;

		public int Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public string Phonenumber { get; set; }
		public double Balance { get; set; }
	}

	public class Manager : Person{ }

	public class Employee : Person
	{

	}

	public class User : Person
	{
		public User()
		{
			borrowed_Book_Id1 = 0;
			borrowed_Book_Id2 = 0;
			borrowed_Book_Id3 = 0;
			borrowed_Book_Id4 = 0;
			borrowed_Book_Id5 = 0;
		}

		public DateTime LastPayDay { get; set; }
		public int borrowed_Book_Id1 { get; set; }
		public int borrowed_Book_Id2 { get; set; }
		public int borrowed_Book_Id3 { get; set; }
		public int borrowed_Book_Id4 { get; set; }
		public int borrowed_Book_Id5 { get; set; }

	}
}
