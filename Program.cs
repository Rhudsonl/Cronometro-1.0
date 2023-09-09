// See https://aka.ms/new-console-template for more information

using System;
using System.Threading;



namespace Cronometro // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Menu();
        }

        static void Menu() {
            Console.WriteLine("Escolha uma opção");
            Console.WriteLine("");
            Console.WriteLine("S - secundos");
            Console.WriteLine("M - minutos");
                 var vl = Console.ReadLine();

                 switch(vl){
                      case "S": Start("S");
                      break;
                      case "M": Start("M");
                      break;
                 }

        }

        static void Start(string time) {

            if(time == "S") {

            Console.Clear();
            Console.WriteLine("Digite os segundos:");
           int vl = int.Parse(Console.ReadLine());

           while (vl != 0)
           {
            vl--;
            Console.WriteLine($"{vl}");
            Thread.Sleep(1000);
           }
            }

            if(time == "M") {

            Console.Clear();
            Console.WriteLine("Digite os Minutos:");
           int vl = int.Parse(Console.ReadLine());

           while (vl != 0)
           {
            vl--;
            Console.WriteLine($"{vl}s");
            Thread.Sleep(60000);
           }
            }

        }


    }
}