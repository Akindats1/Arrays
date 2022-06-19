using System;

namespace FreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
          


           string[] monthsName = {"January" , "February" , "March" , "April" , "May", "June" , "July" , "August" , "September" , "October" , "November" , "December"};
           int monthsLength = monthsName.Length;
           Console.WriteLine("Returns the number of months");
           Console.WriteLine($"The number of the months is :{monthsLength} months");
           Console.WriteLine();

           Console.WriteLine("Return the rank of the month");
           for(int index = 0; index < monthsLength; index++)
            {
              Console.WriteLine($"{index}.{monthsName[index]}");
            }
            Console.WriteLine();

            Console.WriteLine("Reverse the months using loop");
            for(int i = monthsName.Length - 1; i >= 0; i--)
            {
              Console.WriteLine(monthsName[i]);
            }
            Console.WriteLine();

             Console.WriteLine("Reverse the months using array method");
             Array.Reverse(monthsName);
             foreach(string month in monthsName)
             {
               Console.WriteLine(month);
             }
              Console.WriteLine();
              Console.WriteLine("Sort the months in alphabetical order using array method");
             Array.Sort(monthsName);
             foreach(string months in monthsName)
             {
              Console.WriteLine(months);
             }
             Console.WriteLine();
             Console.WriteLine("Copy the first six months to another loop");
             string [] firstSixMonths = new string[6];
             Array.Copy(monthsName, 0, firstSixMonths, 0, 6);
             foreach(string someMonths in firstSixMonths)
             {
              Console.WriteLine(someMonths);
             }
             Console.WriteLine();

             Console.WriteLine("Clone the months using array method.");
             string[] monthClone = (string[])monthsName.Clone();
             foreach(string element in monthClone)
             {
              Console.WriteLine(element);
             }
             //Console.Read();
             Console.WriteLine();

             Console.WriteLine("Clears months starting from index 6.");
             Array.Clear(monthsName ,6,6);
             foreach(string months in monthsName)
             {
              Console.WriteLine(months);
             }
             Console.WriteLine();
             Console.WriteLine("Clear all the months.");
             Array.Clear(monthsName , 0, monthsName.Length);
             foreach(string element2 in monthsName)
             {
              Console.WriteLine(element2);
             }
            
            
            
             


            



        }
    }
}
