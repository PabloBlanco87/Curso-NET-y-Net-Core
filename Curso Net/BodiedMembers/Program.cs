using System;

namespace BodiedMembers
{
    class Student
    {

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fullname { get; set; }
        public string Age { get; set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        //public override string ToString()
        //{
        //    return $"{Fullname}, {Age}";
        //}

        //El método de arriba y este de abajo son iguales, se puede hacer con una expresión inline, es un atajo

        public override string ToString() => $"{Fullname}, {Age}";

        //También se puede hacer así:

        private int age;
        public int Age2
        {
            get => age;
            //Para setearlo hacemos una comprobación, del valor que nos pasan, sea mayor que cero, si no, daremos un argumento outException
            set => age = value > 0 ? value : throw new ArgumentOutOfRangeException(nameof(value));
        }

        //Constructores
        //public Student(string name, string surname, int age)
        //{
        //    Name = name;
        //    Surname = surname;
        //    Age2 = age;
        //}

        //El contructor de arriba y este son iguales
        public Student(string name, string surname, int age) => (Name, Surname, Age2) = (name, surname, age);

        //Destructores solo podemos tener uno por cada clase.
        //Se hace así, virguila + nombre de la clase

    }
}
