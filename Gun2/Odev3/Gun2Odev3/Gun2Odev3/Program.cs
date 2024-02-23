using Gun2Odev3.Business.Concretes;
using Gun2Odev3.DataAccess.Concretes;
using Gun2Odev3.Entities.Concretes;

namespace Gun2Odev3;

class Program
{
    static void Main(string[] args)
    {

        // Ödev:
        // Kodlama.io ana sayfasında bulunan Course, Category, Instructor nesnelerini modelleyiniz.
        // İlişkileri kurunuz. Tüm CRUD operasyonlarını katmanlı yapıda simüle ediniz.
        // Github kodlarınızı paylaşınız.

        CourseManager courseManager = new CourseManager(new CourseDal());
        List<Course> courses = courseManager.GetAll();
        CategoryManager categoryManager = new CategoryManager(new CategoryDal());
        List<Category> categories = categoryManager.GetAll();
        InstructorManager instructorManager = new(new InstructorDal());
        List<Instructor> instructors = instructorManager.GetAll();

        foreach (var category in categories)
        {
            Console.WriteLine("\n * * * * * * * * * * * * * * * * * * \n");
            Console.WriteLine("Kategori ID: {0}",category.Id);
            Console.WriteLine("Kategori Adı: {0}\n", category.Name);
            Console.WriteLine("Bu kategoriye ait kurslar aşağıda listelenmiştir.");
            foreach (var courseId in category.CourseIds)
            {
                Console.WriteLine("\n * * * \n");
                Course course = courseManager.GetById(courseId);
                Console.WriteLine("Kurs ID: {0}",course.Id);
                Console.WriteLine("Kurs Adı: {0}",course.Name);
                Console.WriteLine("Kurs Açıklaması: {0}",course.About);
                int i = 1;
                foreach (var instructorId in course.InstructorIds)
                {
                    Console.WriteLine("\n * \n");
                    Console.WriteLine("Kurs Eğitmeni Bilgileri - {i} \n");
                    Instructor instructor = instructorManager.GetById(instructorId);
                    Console.WriteLine("ID: {0}", instructor.Id);
                    Console.WriteLine("Fotoğraf: {0}", instructor.PhotoFilePath);
                    Console.WriteLine("Ad Soyad: {0} {1}",instructor.FirstName, instructor.LastName);
                    Console.WriteLine("Hakkında: {0}",instructor.About);
                    Console.WriteLine("\n * \n");
                    i = i + 1;
                }
                Console.WriteLine("\n * * * \n");
            }
            Console.WriteLine("\n * * * * * * * * * * * * * * * * * * \n");
        }
        Console.ReadLine();
    }
}

