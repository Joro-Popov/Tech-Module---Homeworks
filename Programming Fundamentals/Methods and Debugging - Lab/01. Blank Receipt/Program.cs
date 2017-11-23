using System;
using System.Text;

namespace _01._Blank_Receipt
{
    class Program
    {
        static void header()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void middle()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void footer()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
        static void PrintReceipt()
        {
            header();
            middle();
            footer();
        }

        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            PrintReceipt();
        }
    }
}
