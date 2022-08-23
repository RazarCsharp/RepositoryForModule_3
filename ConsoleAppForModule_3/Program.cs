using System;

namespace ConsoleAppForModule_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string myName = "\n \n \n \t \t \t \t Wake up Neo ... \n \t \t \t \t The matrix has you ...";

            
            Console.WriteLine(myName);
            Console.WriteLine("\t \t Привет,\n \t \t мир!");
            Console.WriteLine("\u0023");
            Console.WriteLine("\x01");
            Console.WriteLine(0x0A);
            Console.WriteLine(0b11);
            Console.WriteLine(5.5);

            // Программа для задания 3.3.2
            string MyName = "Jane";
            byte MyAge = 27;
            bool HaveIApet = true;
            double MyShoeSize = 37.5;

            Console.WriteLine("\n My name is " + MyName + "\n My Age " + MyAge+ "\n Do I have a pet? " + HaveIApet + "\n My shoe size is " + MyShoeSize);


            


            Console.ReadKey();
        }
    }
}