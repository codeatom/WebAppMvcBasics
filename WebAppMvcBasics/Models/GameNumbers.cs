using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMvcBasics.Models
{
    public class GameNumbers
    {
        static readonly int min = 1;
        static readonly int max = 101;
        static Random _random = new Random();

        public static string compareNumbers(string num, int randNum)
        {
            bool isInteger = false;
            int guessedNum = 0;
            string status = "";

            isInteger = int.TryParse(num, out guessedNum);

            if (isInteger)
            {
                if (guessedNum < randNum)
                {
                    status = "Your guess is too low!";
                }
                else if (guessedNum > randNum)
                {
                    status = "Your guess is too high!";
                }
                else if (guessedNum == randNum)
                {
                    status = "Congrats! Your guess is correct!";
                }
            }
            else
            {
                status = "Please enter numbers only";
            }

            return status;
        }

        public static int GetRandomNum()
        {
            return _random.Next(min, max);
        }
    }
}
