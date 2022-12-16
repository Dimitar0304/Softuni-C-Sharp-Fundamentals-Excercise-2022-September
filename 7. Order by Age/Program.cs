using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            List<Person> persons = new List<Person>();
            while (input[0]!="End")
            {
                string name = input[0];
                string personId = input[1];
                int age = int.Parse(input[2]);

                if (IsThatIdAlreadyExsist(persons, personId))
                {
                    foreach (var curPerson in persons.Where(p=>p.PersonId == personId))
                    {
                        curPerson.Name = name;
                        curPerson.Age = age;
                    }
                }
                else
                {
                    Person person = new Person(name, personId, age);
                    persons.Add(person);
                }
       
                input = Console.ReadLine().Split();
            }
            foreach (var person in persons.OrderBy(p=>p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.PersonId} is {person.Age} years old.");
            }
        }
        static bool IsThatIdAlreadyExsist(List<Person>persons,string personId)
        {
            return persons.Any(p=>p.PersonId == personId);
        }
    }
    class Person
    {
        public Person(string name,string personId,int age)
        {
            Name = name;
            PersonId = personId;
            Age = age;
        }
        public string Name { get; set; }
        public string PersonId { get; set; }
        public int Age { get; set; }
    }
}
