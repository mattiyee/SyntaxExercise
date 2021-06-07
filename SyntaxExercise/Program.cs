using System;

namespace SyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Original Code
            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + "is less than nine.";
            }
            else
            {
                response = answer + "greater than or equal to nine.";
            }

            // New Code
            var newAnswer = 4;
            var newResponse = (answer < 9) ? newAnswer + "is less than nine." : newAnswer + "greater than or equal to nine.";

        }
    }
}
