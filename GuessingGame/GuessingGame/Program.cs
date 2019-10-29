using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 0, B = 100;
            int count = 1;
            string answer;
            while(B > A  + 1)
            {
                int c = (A + B) / 2;
                Console.WriteLine("Q{0} : Is your number > {1} ?", count, c);
                count++;
                answer = Console.ReadLine();
                if (answer == "Y")
                    A = c + 1;
                if (answer == "N")
                    B = c;
            }
            Console.Write("Q{0}: Is your num > {1} ?", count, A);
            answer = Console.ReadLine();
            if (answer == "Y")
                Console.WriteLine("Your num is: " + A);
            if (answer == "N")
                Console.WriteLine("Your num is:" + B);
        }
    }
}