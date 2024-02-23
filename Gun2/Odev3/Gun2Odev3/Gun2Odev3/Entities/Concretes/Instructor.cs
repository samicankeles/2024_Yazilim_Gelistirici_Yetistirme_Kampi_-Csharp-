using System;
using Gun2Odev3.Entities.Abstracts;

namespace Gun2Odev3.Entities.Concretes
{
	public class Instructor : IInstructor
	{
		public Instructor()
		{
		}
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhotoFilePath { get; set; }
		public string About { get; set; }

	}
}

