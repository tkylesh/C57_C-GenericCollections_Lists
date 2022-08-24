using System;
using System.Collections.Generic;
using collectionsExamps.Models;

namespace collectionsExamps
{
    class Program
    {
        static void Main()
        {
            /* A list is bound to be your most frequently used type in the Generic Collections namespace
            because it allows you to resize the contents of the container dynamically*/
            /*Ex. 1 - List<T>*/
            // List<int> moreInts = new List<int>();
            // moreInts.Add(10);
            // moreInts.Add(2);
            // int sum = moreInts[0] + moreInts[1];
            // Console.WriteLine(sum);
            // moreInts.Add("NOPE");

            /*List Initialization*/
            // List<int> evenMoreInts = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            /*List Initialization and Object Initiaization blended*/
            List<Person> people = new List<Person>
            {
                new Person {FirstName = "Homer", LastName = "Simpson", Age=39},
                new Person {FirstName = "Marge", LastName = "Simpson", Age=37},
                new Person {FirstName = "Lisa", LastName = "Simpson", Age=10},
                new Person {FirstName = "Bart", LastName = "Simpson", Age=8}
            };

            //Print out # of items in List.
            Console.WriteLine($"Items in List: {people.Count}");

            //Enumerate over list
            // foreach (Person p in people)
            // Console.WriteLine(p.Stringify());

            //Insert a new person, inserts at specified index
            people.Insert(2, new Person { FirstName = "Maggie", LastName = "Simpson", Age = 1 });
            // Console.WriteLine($"Items in List: {people.Count}");
            // foreach (Person p in people)
            //     Console.WriteLine(p.Stringify());

            //AddRange
            //This works with any collection that implements the IEnumerable<T> interface
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1?view=net-6.0
            Person[] arrayOfPeople =
            {
                new Person{FirstName="Ned", LastName="Flanders", Age=39},
                new Person{FirstName="Rod", LastName="Flanders", Age=10},
                new Person{FirstName="Todd", LastName="Flanders", Age=8}
            };

            people.AddRange(arrayOfPeople);
            // Console.WriteLine($"Items in List: {people.Count}");
            // foreach (Person p in people)
            //     Console.WriteLine(p.Stringify());

            //Find
            //takes a Predicate<T> argument that defines the conditions of the element to search for
            // Console.WriteLine(people.Find(x => x.FirstName.Contains("Bart")));


            //RemoveAt
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.remove?view=net-6.0
            //Remove vs RemoveAt
            //https://stackoverflow.com/questions/10018957/how-to-remove-item-from-list-in-c
            //if you RemoveAt something from beginning or middle of the list the index of the following elements will decrease by 1
            // people.RemoveAt(0);
            // Console.WriteLine($"Items in List: {people.Count}");
            // foreach (Person p in people)
            //     Console.WriteLine(p.Stringify());

            // people.Remove(people.Find(x => x.FirstName == "Ned"));
            // Console.WriteLine($"Items in List: {people.Count}");
            // foreach (Person p in people)
            //     Console.WriteLine(p.Stringify());

            //Contains
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.contains?view=net-6.0
            //boolean: true if found; otherwise, false
            // Console.WriteLine(people.Contains(people.Find(x => x.FirstName.Contains("Homer"))));
            // if (people.Contains(people.Find(x => x.FirstName == "Taylor")))
            // {
            //     Console.WriteLine("We found Marge!");
            // }
            // else
            // {
            //     Console.WriteLine("We didn't find Marge.");
            // }

        }
    }
}
