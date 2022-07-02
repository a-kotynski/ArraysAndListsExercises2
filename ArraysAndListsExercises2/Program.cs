using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://www.udemy.com/course/csharp-tutorial-for-beginners/learn/lecture/2910726#content
/* 2 - write a program that asks a user to enter their name. 
 * Use an array to reverse the name and then store the result in a new string. 
 * Display the reversed name on the console.*/
namespace ArraysAndListsExercises2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* My attempt:
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            string[] nameArray = new string[] {name};
            Array.Reverse(nameArray);

            //string[] nameArray2 = new string[nameArray.Length];
            //Array.Copy(nameArray, nameArray2 , nameArray.Length);

            foreach (var n in nameArray)
            {
                Console.WriteLine(n);
            }
            */

            // example below hasn't used any arrays:

            Console.WriteLine("Enter name: ");
            var name = Console.ReadLine();
            var reversedName = GetReversedName(name);

            Console.WriteLine($"Name \"{name}\" became \"{reversedName}\"");
        }
        private static string GetReversedName(string name)
        {
            var list = name.ToList();
            list.Reverse();

            return string.Join("", list.ToArray());
        }
    }
}