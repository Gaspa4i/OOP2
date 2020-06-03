using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{

    class TV
    {
        int correctChannel = 0;
        bool TVEnabled;
        int TVChannel;
        public void TVOn()
        {
            TVEnabled = true;
            Console.WriteLine("\n + это следующий канал" +
                "\n - это предыдущий канал");
        }
        public int TVChannelNext()
        {
            if (correctChannel < 10)
            {
                correctChannel++;
                TVChannel = correctChannel;
                return correctChannel;
            }
            else
            {
                correctChannel = 0;
                TVChannel = correctChannel;
                return correctChannel;
            }
        }
        int TVChannelPrevious()
        {
            if (correctChannel > 0)
            {
                correctChannel--;
                TVChannel = correctChannel;
                return correctChannel;
            }
            else
            {
                correctChannel = 10;
                TVChannel = correctChannel;
                return correctChannel;
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                TV TV1 = new TV();
                    TV1.TVOn();
                string Enter = Console.ReadLine();
                while (TV1.TVEnabled == true)
                {
                   if (Enter == "+") 
                    {
                        Console.WriteLine("Канал  " + TV1.TVChannelNext());
                    }
                    else if (Enter == "-")
                    {
                        Console.WriteLine("Канал  " + TV1.TVChannelPrevious());
                    }
                    Console.Write("Какой будет следующий канал? ");
                    Enter = Console.ReadLine();
                }
            }

        }
    }
}
