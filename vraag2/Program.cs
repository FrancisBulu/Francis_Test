using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vraag2
{
    class Program
    {
        static void Main(string[] args)
        {
            int score1 = 8;
            int score2 = 6;
            int score3 = 9;
            int score4 = 4;

            int gemid = (score1 + score2 + score3 + score4)/4;
            decimal perc = gemid / 100;

            Console.WriteLine($"De gemiddelde score is {gemid}");
            Console.WriteLine($"De percentage is {perc}");



        }
    }
}
