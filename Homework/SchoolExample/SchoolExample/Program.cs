using SchoolExample.Business.Concrete;
using SchoolExample.Entities;
using SchoolExample.Repositories.Concrete;

TeacherManager teacherManager = new(teacherRepository: new TeacherRepository());
Teacher teacher = new();
StudentManager studentManager = new(studentRepository: new StudentRepository());
Student student = new();
ClassroomManager classroomManager = new(classroomRepository: new ClassroomRepository());
Classroom classroom = new();

bool start = true;

Console.WriteLine("Selam sana hitap edebilmem için adını girmelisin..");
string name = Console.ReadLine();
Console.WriteLine($"Hoşgeldin {name} lütfen yapmak istediğin işlemi seç..");
Console.WriteLine("Öğretmen İşlemleri için(1) | Öğrenci İşlemleri için(2) | Sınıf İşlemleri için(3) | Çıkış(4)");
string vote = Console.ReadLine();
Console.WriteLine("********************************************************************************");

switch (vote)
{
    case "1":
        Teacher();
        break;
    case "2":
        Student();
        break;
    case "3":
        Classroom();
        break;
    case "4":
        break;
    default:
        break;
}

void Teacher()
{
    while (start)
    {
        Console.WriteLine("Öğretmen işlemleri ekranındasın lütfen yapmak istediğin işlemi seç..");
        Console.WriteLine("Öğretmenleri Listele(1) | Öğretmen Ekle(2) | Öğretmen Sil(3) | Çıkış(4)");
        string vote = Console.ReadLine();

        if (vote is "1")
        {
            var teachers = teacherManager.GetAll();
            teachers.Data.ForEach(x => Console.WriteLine($"Id:{x.Id} Ad:{x.Name} Soyad:{x.Surname} Branş:{x.Branch}"));
            Console.WriteLine(teachers.Message);
        }
        else if (vote is "2")
        {
            Console.Write("Id giriniz: ");
            teacher.Id = int.Parse(Console.ReadLine());
            Console.Write("Ad giriniz: ");
            teacher.Name = Console.ReadLine();
            Console.Write("Soyad giriniz: ");
            teacher.Surname = Console.ReadLine();
            Console.Write("Branş giriniz: ");
            teacher.Branch = Console.ReadLine();
            var added = teacherManager.Add(teacher);
            Console.WriteLine(added.Message);
        }
        else if (vote is "3")
        {
            Console.WriteLine("Silmek istediğin Id numarası seç..");
            var deleted = teacherManager.Remove(int.Parse(Console.ReadLine()));
            Console.WriteLine(deleted.Message);
        }
        else if (vote is "4")
            start = false;
        else
            Console.WriteLine("Hatalı bir işlem seçtin..");

        Console.WriteLine("********************************************************************************");
    }
}
void Student()
{
    while (start)
    {
        Console.WriteLine("Öğrenci işlemleri ekranındasın lütfen yapmak istediğin işlemi seç..");
        Console.WriteLine("Öğrencileri Listele(1) | Öğrenci Ekle(2) | Öğrenci Sil(3) | Çıkış(4)");
        string vote = Console.ReadLine();

        if (vote is "1")
        {
            var students = studentManager.GetAll();
            students.Data.ForEach(x => Console.WriteLine($"Id:{x.Id} Ad:{x.Name} Soyad:{x.Surname} Numarası:{x.SchoolNumber}"));
            Console.WriteLine(students.Message);
        }
        else if (vote is "2")
        {
            Console.Write("Id giriniz: ");
            student.Id = int.Parse(Console.ReadLine());
            Console.Write("Ad giriniz: ");
            student.Name = Console.ReadLine();
            Console.Write("Soyad giriniz: ");
            student.Surname = Console.ReadLine();
            Console.Write("Okul Numarası giriniz: ");
            student.SchoolNumber = Console.ReadLine();
            var added = studentManager.Add(student);
            Console.WriteLine(added.Message);
        }
        else if (vote is "3")
        {
            Console.WriteLine("Silmek istediğin Id numarası seç..");
            var deleted = studentManager.Remove(int.Parse(Console.ReadLine()));
            Console.WriteLine(deleted.Message);
        }
        else if (vote is "4")
            start = false;
        else
            Console.WriteLine("Hatalı bir işlem seçtin..");

        Console.WriteLine("********************************************************************************");
    }
}
void Classroom()
{
    while (start)
    {
        Console.WriteLine("Sınıf işlemleri ekranındasın lütfen yapmak istediğin işlemi seç..");
        Console.WriteLine("Sınıfları Listele(1) | Sınıf Ekle(2) | Sınıf Sil(3) | Çıkış(4)");
        string vote = Console.ReadLine();

        if (vote is "1")
        {
            var classrooms = classroomManager.GetAll();
            classrooms.Data.ForEach(x => Console.WriteLine($"Id:{x.Id} Sınıf Adı:{x.ClassName}"));
            Console.WriteLine(classrooms.Message);
        }
        else if (vote is "2")
        {
            Console.Write("Id giriniz: ");
            classroom.Id = int.Parse(Console.ReadLine());
            Console.Write("Sınıf Adı giriniz: ");
            classroom.ClassName = Console.ReadLine();
            var added = classroomManager.Add(classroom);
            Console.WriteLine(added.Message);
        }
        else if (vote is "3")
        {
            Console.WriteLine("Silmek istediğin Id numarası seç..");
            var deleted = classroomManager.Remove(int.Parse(Console.ReadLine()));
            Console.WriteLine(deleted.Message);
        }
        else if (vote is "4")
            start = false;
        else
            Console.WriteLine("Hatalı bir işlem seçtin..");

        Console.WriteLine("********************************************************************************");
    }
}
