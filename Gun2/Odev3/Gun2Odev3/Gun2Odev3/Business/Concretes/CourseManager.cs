using System;
using Gun2Odev3.Business.Abstracts;
using Gun2Odev3.DataAccess.Abstracts;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.Business.Concretes
{
    public class CourseManager : ICourseManager
	{
		private readonly ICourseDal _courseDal;
		public CourseManager(ICourseDal courseDal)
		{
			_courseDal = courseDal;
		}

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

        public Course GetById(int id)
        {
            return _courseDal.GetById(id);
        }

        public void Update(int oldCourseId, Course newCourse)
        {
            _courseDal.Update(oldCourseId, newCourse);
        }
    }
}

