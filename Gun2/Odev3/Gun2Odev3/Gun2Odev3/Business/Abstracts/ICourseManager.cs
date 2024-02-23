using System;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.Business.Abstracts
{
	public interface ICourseManager
	{
		List<Course> GetAll();
		Course GetById(int id);
		void Add(Course course);
		void Update(int oldCourseId, Course newCourse);
		void Delete(Course course);
	}
}

