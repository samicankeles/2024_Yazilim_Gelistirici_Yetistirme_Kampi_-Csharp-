using System;
using Gun2Odev3.Entities.Abstracts;

namespace Gun2Odev3.Entities.Concretes
{
    public class Category : ICategory 
	{
		public Category()
		{
		}
		public int Id { get; set; }
		public string Name { get; set; }
		public List<int> CourseIds { get; set; }
	}
}

