using System;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.DataAccess.Abstracts
{
	public interface ICourseDal
	{
		List<Course> GetAll();
		Course GetById(int id);
		void Add(Course course);
		void Update(int oldCourseId, Course newCourse);
		void Delete(Course course);
	}
}

