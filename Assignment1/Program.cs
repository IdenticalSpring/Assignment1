using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program start");
            Random random = new Random();
            int number = random.Next(100, 999);
            string targetNumber = number.ToString();
            Console.WriteLine($"{targetNumber}");
            int attemp = 1, MAX = 7;
            string guess, feedback = "";
            while (feedback != "+++" & attemp <= MAX){
                Console.WriteLine("Guess Attempt {0}", attemp);
                guess = Console.ReadLine();
                feedback = getFeedback(targetNumber, guess);
                Console.WriteLine(feedback);
                attemp++;
            }
            if (attemp > MAX)
                Console.WriteLine("You lose");
            else
                Console.WriteLine("You win");
            Console.ReadLine();
                 
        }
        static string getFeedback(string target, string guess)
        {
            string feedback = "";
            for( int i = 0; i < target.Length; i++ )
            {
                if (target[i] == guess[i])
                    feedback += "+";
                else if (target.Contains(guess[i].ToString()))
                    feedback += "?";
                else if (!target.Contains(guess[i].ToString()))
                    feedback += "Bruh";
            }
            return feedback;
        }
    }
}
