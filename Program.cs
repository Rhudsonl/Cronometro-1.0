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
            Console.Clear();
            Console.WriteLine("S = Sengundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 1m = 1 minuto");
            Console.WriteLine("0 Sair");
            Console.WriteLine("Quanto tempo deseja contar?");
               
               string data = Console.ReadLine().ToLower();

               char type = char.Parse(data.Substring(data.Length - 1,1));
               int time = int.Parse(data.Substring(0,data.Length - 1));

               int multiplier = 1;

               if(type == 'm') {
                multiplier = 60;
               }

               if(time == 0) {
                System.Environment.Exit(0);
               }

               Start(time * multiplier);

        }

        

        static void Start(int time) {

            

           while (time != 0)
           {
            time--;
            Console.WriteLine($"{time}");
            Thread.Sleep(1000);
           }
            }

            

        }


    }
