using Gun2Odev3.Business.Abstracts;
using Gun2Odev3.Business.Concretes;
using Gun2Odev3.DataAccess.Concretes;
using Gun2Odev3.Entities.Abstracts;
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


        Console.WriteLine("\n* * * ÖNCEKİ KATEGORİ BİLGİLERİ * * *\n");
        foreach (var category in categories)
        {
            categoryManager.Show(category);
        }

        categoryManager.Add(new Category
        {
            Id = 101,
            Name = "Yeni Kategori",
            CourseIds = new List<int> {101}
        });

        List<int> courseIds = new List<int>();
        foreach (var courseId in categoryManager.GetAll()[1].CourseIds)
        {
            courseIds.Add(courseId);
        }
        courseIds.Add(101);
        categoryManager.Update(categoryManager.GetAll()[1].Id, new Category
        {
            Name = categoryManager.GetAll()[1].Name + " güncellendi",
            CourseIds = courseIds
        });

        categoryManager.Delete(categoryManager.GetAll()[0]);

        Console.WriteLine("\n* * * SONRAKİ KATEGORİ BİLGİLERİ * * *\n");
        foreach (var category in categories)
        {
            categoryManager.Show(category);
        }

        Console.WriteLine("**********************************");



        Console.WriteLine("\n* * * ÖNCEKİ KURS BİLGİLERİ * * *\n");
        foreach (var course in courses)
        {
            courseManager.Show(course);
        }

        courseManager.Add(new Course
        {
            Id = 101,
            Name = "Yeni Kurs",
            About = "Yeni Kurs Açıklaması",
            InstructorIds = new List<int> { 101 }
        });

        List<int> instructorIds = new List<int>();
        foreach (var instructorId in courseManager.GetAll()[1].InstructorIds)
        {
            instructorIds.Add(instructorId);
        }
        instructorIds.Add(101);
        courseManager.Update(courseManager.GetAll()[1].Id, new Course
        {
            Name = courseManager.GetAll()[1].Name + " güncellendi",
            About = courseManager.GetAll()[1].About + " güncellendi",
            InstructorIds = instructorIds
        });

        courseManager.Delete(courseManager.GetAll()[0]);

        Console.WriteLine("\n* * * SONRAKİ KURS BİLGİLERİ * * *\n");
        foreach (var course in courses)
        {
            courseManager.Show(course);
        }

        Console.WriteLine("**********************************");



        Console.WriteLine("\n* * * ÖNCEKİ EĞİTMEN BİLGİLERİ * * *\n");
        foreach (var instructor in instructors)
        {
            instructorManager.Show(instructor);
        }

        instructorManager.Add(new Instructor
        {
            Id = 101,
            FirstName = "Yeni Eğitmenin Adı",
            LastName = "Yeni Eğitmenin Soyadı",
            About = "Yeni Eğitmen Bilgisi",
            PhotoFilePath = "Photos/12345678910.png"
        });

        instructorManager.Update(instructorManager.GetAll()[1].Id, new Instructor
        {
            FirstName = instructorManager.GetAll()[1].FirstName + " güncellendi",
            LastName = instructorManager.GetAll()[1].LastName + " güncellendi",
            About = instructorManager.GetAll()[1].About + " güncellendi",
            PhotoFilePath = instructorManager.GetAll()[1].PhotoFilePath + " güncellendi",
        });

        instructorManager.Delete(instructorManager.GetAll()[0]);

        Console.WriteLine("\n* * * SONRAKİ KATEGORİ BİLGİLERİ * * *\n");
        foreach (var instructor in instructors)
        {
            instructorManager.Show(instructor);
        }

        Console.WriteLine("**********************************");



        Console.ReadLine();

    }

}


