using System;

namespace ConsoleAppDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Opgave 1: Udskriv alle studerende");
            Console.WriteLine("=================================");

            foreach (var i in StudentFacade.GetAllStudents())
            {
                Console.WriteLine($"Navn: {i.Navn}\n Id: {i.StudentId}\t Mobil: {i.MobilNr}\n Hold: {i.Hold}\t ");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("Opgave 2: Udskriv enkelt studerende");
            Console.WriteLine("===================================");
            Console.WriteLine(ExamFacade.GetOneStudents(2));
            Console.WriteLine("===================================");
            Console.WriteLine("Opgave 3: Slet en exam");
            Console.WriteLine("===================================");

        }
    }
}
