using System;

namespace _17032022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                Name = "Hikmet",
                Surname = "Abbasov",
                AvgPoint = 70
            };

            Student student1 = new Student()
            {
                Name = "Hafiz",
                Surname = "Mehdiyev",
                AvgPoint = 85
            };

            Student student2 = new Student()
            {
                Name = "Allahverdi",
                Surname = "Ahmedov",
                AvgPoint = 0
            };

            Group group = new Group()
            {
                No = "AP203",
                StudentLimit = 5
            };

            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);

            //foreach (var item in group.students)
            //{
            //    Console.WriteLine(item.Name);
            //}

            foreach (var item in group.FilterStudentByName("t ab"))
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
