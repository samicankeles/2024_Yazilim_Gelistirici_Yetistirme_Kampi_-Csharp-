using System;
using Gun2Odev3.DataAccess.Abstracts;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.DataAccess.Concretes
{
	public class CourseDal : ICourseDal
	{
        private List<Course> _courses;
		public CourseDal()
		{
            _courses = new List<Course>
            {
                new Course
                {
                    Id = 98,
                    Name = "0'dan !00'e - C#",
                    About = "256 saat ders ile sıfırdan uzmanlık seviyesinde C# öğreneceksiniz !",
                    InstructorIds = new List<int> {26, 196}
                },
                new Course
                {
                    Id = 3,
                    Name = "Master Seviye C++",
                    About = "Bu kursta 221 saat ders ile eğer orta düzeydeyseniz master düzeyinde C++ öğreneceksiniz !",
                    InstructorIds = new List<int> {196, 974}
                },
                new Course
                {
                    Id = 871,
                    Name = "Yeni Başlayanlara Python",
                    About = "Hiçbirşey bilmesen bile 27 saat ders ile başlangıç seviyesinde Python öğrenebilirsin !",
                    InstructorIds = new List<int> {26, 974}
                }
            };
		}

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            Course result = new Course();
            foreach (var course in _courses)
            {
                if (course.Id == id)
                {
                    result = course;
                    break;
                }
            }
            return result;
        }

        public void Update(int oldCourseId, Course newCourse)
        {
            for (int i = 0; i < _courses.Count; i++)
            {
                if (_courses[i].Id == oldCourseId)
                {
                    newCourse.Id = _courses[i].Id;
                    _courses[i] = newCourse;
                    break;
                }
            }
        }
    }
}

