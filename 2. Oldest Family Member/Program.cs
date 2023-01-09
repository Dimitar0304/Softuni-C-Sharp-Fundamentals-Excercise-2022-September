using System;
using System.Collections.Generic;

namespace _2._Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //we will create two classes first is Person wich will has Name and Age like properties
            //second class will be Family wich will contains:
            //1=>list<Person> property,
            //2=>Method Add people to family list public void AddMember(),
            //3 Method that print the oldest member in list of Person or Family
            // Output => {Name} {Age}
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            Family family = new Family(persons);
            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string name = info[0];
                int age = int.Parse(info[1]);

                Person person = new Person(name, age);
               
                family.AddMember(person,persons);
            }
            family.GetOldestMember(persons);


        }
        class Person
        {
            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public string Name { get; set; }
            public int Age { get; set; }

        }
        class Family
        {

            public Family(List<Person>persons)
            {
                Person = persons;
            }
            public List<Person> Person = new List<Person>();

            public void AddMember(Person person,List<Person>persons)
            {
               persons.Add(person);
            }
            public void GetOldestMember(List<Person>persons)
            {
                int currentOldestPerson = 0;
                string oldestName = string.Empty;
                for (int i = 0; i < persons.Count; i++)
                {
                   
                    if (persons[i].Age>=currentOldestPerson)
                    {
                        oldestName = persons[i].Name;
                        currentOldestPerson = persons[i].Age;
                    }
                   
                }
                Console.WriteLine($"{oldestName} {currentOldestPerson}");
            }
        }
    }
}
