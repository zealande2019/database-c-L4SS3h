using System;

namespace ConsoleAppDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            foreach (var i in StudentFacade.GetAllStudents())
            {
                Console.WriteLine($"Navn: {i.Navn}\n Id: {i.StudentId}\t Mobil: {i.MobilNr}\n Hold: {i.Hold}\t ");
            }
        }
    }
}
