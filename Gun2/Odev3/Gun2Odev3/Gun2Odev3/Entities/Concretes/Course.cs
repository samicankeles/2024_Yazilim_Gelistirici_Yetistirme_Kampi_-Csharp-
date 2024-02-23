using System;
using Gun2Odev3.Entities.Abstracts;

namespace Gun2Odev3.Entities.Concretes
{
	public class Course : ICourse
	{
		public Course()
		{
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public string About { get; set; }
		public List<int> InstructorIds { get; set; }
	}
}

