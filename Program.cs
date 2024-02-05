using System;
using System.Collections.Generic;
using System.Linq;
using Google.Cloud.Translation.V2;
using HomeWorks;

namespace TranslationApiDemo
{
    class Program
    {
        static void Main(string[] args)


        {
            var people = new List<Person>
{
    new Person ("Tom", 23, "Minks", false),
    new Person ("Bob", 27, "Moscow", true),
    new Person ("Sam", 29, "King of Prussia", true),
    new Person ("Alice", 24, "Kiev", false),
    new Person ("Fon", 55, "Gili", false),
    new Person ("Ron", 71, "Dalas", false),
    new Person ("Hohe", 23, "New York", false),
    new Person ("Shon", 13, "Kiev", false),
    new Person ("Mark", 41, "Sluck", true),
    new Person ("Nove", 32, "Phily", false),
    new Person ("Lolin", 18, "Stambul", true),
    new Person ("Spenser", 15, "Wayn", true)
};

            var NameStartsS = people.Where(p => p.Name.ToUpper().StartsWith("S")).ToList();

            Console.WriteLine("Persons with names starting with S:");

            //In the foreach loop, person is an instance of the Person class, representing each element in the NameStartsS collection.
            //It allows you to access the properties of each person, such as Name, for printing purposes.
            foreach (var person in NameStartsS)
            {
                Console.WriteLine($"{person.Name}");
            }

            var AgeOver30 = people.Where(p => p.Age > 30).ToList();

            int countAgeOver30 = AgeOver30.Count;
            Console.WriteLine($" People over 30 years old : {countAgeOver30}");





            var IsEmployee = people.Where(p => p.IsEmployee == true).ToList();
            foreach (var person in IsEmployee)
            {
                Console.WriteLine($" {person.Name} is an employee ");
            }
            //didnt undestand how to do it, how to get only name who lives in unique citys
            var uniqueNamesWithCities = people.GroupBy(p => new { p.Name, p.City }).Select(group => group.First()).ToList();

            Console.WriteLine("Names with unique cities:");
            foreach (var person in uniqueNamesWithCities)
            {
                Console.WriteLine($"{person.Name} - {person.City}");
            }

            var OrderByAge = people.OrderBy(p => p.Age).ToList();
            foreach (var person in OrderByAge)
            {
                Console.WriteLine($"{person.Age}");
            }


            var OrderByNameAndAge = people.GroupBy(p => new { p.Name, p.Age }).OrderBy(h => h.Key.Age).ToList();
            foreach (var group in OrderByNameAndAge)
            {
                foreach(var person in group)
                {
                    Console.WriteLine($"{person.Name} -{person.Age}");

                }
            }

            int GetSum = people.Sum(p => p.Age);
            Console.WriteLine($" sum of all ages ={GetSum}");

            var MaxAge = people.Max(p => p.Age);
            Console.WriteLine($" max Age is {MaxAge}");

            var CountPersonsInEachCity = people.GroupBy(p => new { p.Name, p.City }).OrderBy(h => h.Key.City).ToList();
            foreach( var group in CountPersonsInEachCity)
            {
                foreach(var person in group)
                {
                    Console.WriteLine($"{person.Name} - {person.City}");
                }
            }

            var orderByCity = people.OrderBy(p=> p.City).ToList();
            foreach(var person in orderByCity)
            {
                Console.WriteLine($"List of Cities {person.City}");
            }
        }
    }
}

