using System;

namespace ClassesAndObjects
{
    class Program
    {
        static Student[] students = new Student[20];
        static void Main(string[] args)
        {

            #region Class intro
            //Car bmw = new Car();

            //bmw.marka = "BMW";
            //bmw.model = "M8";
            //bmw.color = "Black";
            //bmw.price = 50_000.0m;

            //Console.WriteLine($"Marka: {bmw.marka}\n" +
            //    $"Model: {bmw.model}");

            //Car mercedes = new Car();

            //mercedes.price = 40_000.00m;
            //mercedes.marka = "Mercedes";
            //mercedes.model = "S Class";
            //mercedes.color = "White";

            //Console.WriteLine($"Marka: {bmw.marka}\n" +
            //    $"Model: {bmw.model}");
            #endregion

            #region Encapsulation into
            //Student student = new Student();
            //student.id = 1;
            //student.name = "Turan";
            //student.age = 22;
            //student.finCode = "5WGL80Q";
            //student.hasScollarship = false;

            //Student student2 = new Student();
            //student2.id = 2;
            //student2.name = "Orxan";
            //student2.age = 19;
            //student2.finCode = "5WGL2323230Q";
            //student2.hasScollarship = true;


            //student.Group = "Tk47jasdjaslkdjaskldjksjdslkjdksdjsjdklsjd";

            //Console.WriteLine(student.Group);

            //Console.WriteLine(student);
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(student2);

            //student.ExitUniersity();
            //Console.WriteLine("--------------------");
            //student2.ExitUniersity();
            #endregion


            #region Constructor
            StartApplication();
            #endregion

        }

        private static void StartApplication()
        {
            Console.Clear();
            Console.WriteLine("_________________________WELCOME_________________________");

            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Stundets");

            string choice = Console.ReadLine();
           
            if(choice == "1")
            {
                AddStudent();
            }else if(choice == "2")
            {
                ShowStudents();
            }
        }

        private static void ShowStudents()
        {
            Console.Clear();
            for (int i = 0; i < students.Length; i++)
            {
                if(students[i] != null)
                {
                    Console.WriteLine(students[i]);
                    Console.WriteLine("-------------------------");
                }
                
            }
            Console.ReadKey();
            StartApplication();
        }

        private static void AddStudent()
        {
            Console.Clear();

            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Student Fincode: ");
            string fincode = Console.ReadLine();

            Console.WriteLine("Enter Student Group: ");
            string group = Console.ReadLine();

            Student student = new Student(name,fincode,group);

            students[Student.Index-1] = student;
            Console.WriteLine("Student Added Succefully!!!");
            Console.ReadKey();
            StartApplication();
        }
    }
}
