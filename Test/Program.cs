using System;
using System.Collections.Generic;

namespace test{
    class person{
        public int id;
        public string name;
        public int age;
        public person(int id, string name, int age){
            this.id = id;
            this.name = name;
            this.age = age;
        }
    }

    class Program{
        public static void Main(string[] args)
        {
            var person = new person(12,"Jhon", 45);
            System.Console.WriteLine("Person Name: {0}", person.name);
            System.Console.WriteLine("Person Age: {0}", person.age);
        }
    }
}