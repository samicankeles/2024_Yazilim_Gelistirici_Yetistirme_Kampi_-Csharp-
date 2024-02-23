using System;
using Gun2Odev3.DataAccess.Abstracts;
using Gun2Odev3.Entities.Abstracts;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3.DataAccess.Concretes
{
	public class InstructorDal : IInstructorDal
	{
        private List<Instructor> _instructors;
		public InstructorDal()
		{
            _instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 26,
                    FirstName = "Ali Veli",
                    LastName = "Yılmaz",
                    About = "İstanbul Üniversitesi mezunu, Bilgisayar Mühendisi ve Ankaralı.",
                    PhotoFilePath = "Photos/45321680132.png"
                },
                new Instructor
                {
                    Id = 196,
                    FirstName = "Mehmet",
                    LastName = "Kurt",
                    About = "Kocaeli Üniversitesi mezunu, Biyomedikal Mühendisi ve Bursalı.",
                    PhotoFilePath = "Photos/55321640138.png"
                },
                new Instructor
                {
                    Id = 974,
                    FirstName = "Ahmet",
                    LastName = "Şen",
                    About = "Bolu Üniversitesi mezunu, İnşaat Mühendisi ve Sinoplu.",
                    PhotoFilePath = "Photos/12364203124.png"
                }
            };
		}

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructors.Remove(instructor);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            Instructor result = new Instructor();
            foreach (var instructor in _instructors)
            {
                if (instructor.Id == id)
                {
                    result = instructor;
                    break;
                }
            }
            return result;
        }

        public void Update(int oldInsturctorId, Instructor newInstructor)
        {
            for (int i = 0; i < _instructors.Count; i++)
            {
                if (_instructors[i].Id == oldInsturctorId)
                {
                    newInstructor.Id = _instructors[i].Id;
                    _instructors[i] = newInstructor;
                    break;
                }
            }
        }
    }
}

