using System;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.DataAccess.Abstracts
{
	public interface IInstructorDal
	{
		List<Instructor> GetAll();
		Instructor GetById(int id);
		void Add(Instructor instructor);
		void Update(int oldInstructorId, Instructor newInstructor);
		void Delete(Instructor instructor);
	}
}

