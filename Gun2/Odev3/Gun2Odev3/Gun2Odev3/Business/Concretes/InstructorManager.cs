using System;
using Gun2Odev3.Business.Abstracts;
using Gun2Odev3.DataAccess.Abstracts;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.Business.Concretes
{
	public class InstructorManager : IInstructorManager
	{
		private readonly IInstructorDal _instructorDal;
		public InstructorManager(IInstructorDal instructorDal)
		{
			_instructorDal = instructorDal;
		}

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _instructorDal.GetById(id);
        }

        public void Update(int oldInstructorId, Instructor newInstructor)
        {
            _instructorDal.Update(oldInstructorId, newInstructor);
        }

        public void Show(Instructor instructor)
        {
            Console.WriteLine("ID: {0}", instructor.Id);
            Console.WriteLine("Fotoğraf: {0}", instructor.PhotoFilePath);
            Console.WriteLine("Ad Soyad: {0} {1}", instructor.FirstName, instructor.LastName);
            Console.WriteLine("Hakkında: {0}", instructor.About);
            Console.WriteLine("");
        }
    }
}

