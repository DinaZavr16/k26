using System;
using HWAboutStudent;

namespace HWAboutStudent
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Group k26 = new Group("K-26");
            Student Maevskiy = new BadStudent("Lubomyr");
            Student Formakidova = new GoodStudent("Dina");
            Student Ivanov = new BadStudent("Artem");
            k26.AddStudent(Formakidova);
            k26.AddStudent(Maevskiy);
            k26.AddStudent(Ivanov);
            Console.WriteLine(k26.GetInfo());
            Console.WriteLine(k26.GetFullInfo());

            Console.WriteLine();

            Group k27 = new Group("K-27");
            Student Petrov = new GoodStudent("Petr");
            Student Sidorov = new GoodStudent("Alex");
            Student Bybko = new BadStudent("Sergii");
            k27.AddStudent(Petrov);
            k27.AddStudent(Sidorov);
            k27.AddStudent(Bybko);
            Console.WriteLine(k27.GetInfo());
            Console.WriteLine(k27.GetFullInfo());

            Console.WriteLine();

            k26.AddGroupStudents(k27);
            Console.WriteLine(k26.GetInfo());
            Console.WriteLine(k26.GetFullInfo());
        }
    }
}