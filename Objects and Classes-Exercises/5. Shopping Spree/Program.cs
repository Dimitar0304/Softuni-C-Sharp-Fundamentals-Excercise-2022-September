using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();
            //we will create two clases Person and Product
            //Person props => name,money and bag of products
            //Product props => name and cost
            //we will reciving commands till the END command where people buing some products
            // if currentPerson doesn't has money for currentProduct print "{Person} can't afford {Product}".
            // if it can it add currentProduct to currentPerson's bag

              string[]peoples = Console.ReadLine().Split(';');
            for (int i = 0; i < peoples.Length; i++)
            {
                string[] peopleInfo = peoples[i].Split('=');
                string name = peopleInfo[0];
                int money = int.Parse(peopleInfo[1]);
                List<string> bag = new List<string>();
                Person person = new Person(name, money, bag);
                persons.Add(person);

            }
            string[] items = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < items.Length; i++)
            {
                string[] itemsInfo = items[i].Split('=');
                string name = itemsInfo[0];
                int cost = int.Parse(itemsInfo[1]);
                Product product = new Product(name, cost);
                products.Add(product);
            }

            string command = Console.ReadLine();

            while (command!="END")
            {
                int indexOfcurrentName = 0;
                int indexOfCurrentProduct = 0;
                string[] commandInfo = command.Split();
                string currentName = commandInfo[0];
                string currentProduct = commandInfo[1];
                GetIndexOfName(currentName,persons, ref indexOfcurrentName);
                GetIndexOfProduct(currentProduct, products, indexOfCurrentProduct);
                if (persons[indexOfcurrentName].Money>=products[indexOfCurrentProduct].Cost)
                {
                    persons[indexOfcurrentName].Money -= products[indexOfCurrentProduct].Cost;
                    persons[indexOfcurrentName].Bag.Add(products[indexOfCurrentProduct].Name);
                }
                else
                {
                    Console.WriteLine($"{persons[indexOfcurrentName].PersonName} can't afford {products[indexOfCurrentProduct].Name}");
                }
                command = Console.ReadLine();
            }
            foreach (var people in persons)
            {
                if (people.Bag.Count==0)
                {
                    Console.WriteLine($"{people.PersonName} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{people.PersonName} - {string.Join(',', people.Bag)}");
                }
               
            }
        }

        static  int GetIndexOfProduct(string currentProduct, List<Product> products, int indexOfCurrentProduct)
        {
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name == currentProduct)
                {
                       indexOfCurrentProduct += i;
                   
                }
                return indexOfCurrentProduct;
            }
        }

        static void GetIndexOfName(string currentName, List<Person> persons, ref int indexOfcurrentName)
        {
            for (int i = 0; i < persons.Count; i++)
            {

                if (persons[i].PersonName== currentName)
                {
                    indexOfcurrentName += i;
                    break;
                }
              
            }
        }

        class Product
        {
            public Product(string name,int cost)
            {
                Name = name;
                Cost = cost;
            }
            public string Name { get; set; }
            public int Cost { get; set; }
        }
        class Person
        {
            public Person(string personName,int money,List<string> bag)
            {
                PersonName = personName;
                Money = money;
                Bag = bag;
            }
            public string PersonName { get; set; }
            public int Money { get; set; }
            public List<string> Bag { get; set; }
        }
    }
}
