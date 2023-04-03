using System;

namespace ClassesAndObjects
{
    public class Student
    {

        //private fields

        private string _fincode;
        // public private protected 
        public string Group { get; private set; }   
        public string Name { get; private set; }                           
        public string Fincode
        {
            get { return _fincode; }
            set 
            {
                if (value.Length != 7)
                {
                    Console.WriteLine("Fincode must be minimal 5 character");
                }
                else
                {
                    _fincode = value;
                }
            }
        }
        public static int Index { get; private set; }
         public int Id { get; private set; }


        public Student()
        {
            
            Id = ++Index;
        }

       
        public Student( string name) :this()
        {
            Name= name;
        }
        public Student(string name,string fincode) :this(name)
        {

            Fincode = fincode;
   
        }

        public Student(string name, string fincode, string group) :this(name,fincode)
        {

            Group = group;
        }




        public override string ToString()
        {
            return $"Student Id: {Id}\r\t\t\t|\n" +
                $"Name: {Name}\r\t\t\t|\n" +
                $"Fincode: {Fincode}\r\t\t\t|\n" +
                $"Group: {Group}\r\t\t\t|";
        }


    }
}
