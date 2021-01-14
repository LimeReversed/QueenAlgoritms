using System;
using System.Collections.Generic;

namespace Algoritmer
{
    public class Program
    {
        static void Main(string[] args)
        {
           
        }

        public static int GetLargestOddSum(List<int> array)
        {
            int largestOddNr = 0;
            int largestEvenNr = 0;

            foreach (int nr in array)
            {
                if (IsNumberEven(nr) && nr > largestEvenNr)
                {
                    largestEvenNr = nr;
                }
                else if (!IsNumberEven(nr) && nr > largestOddNr)
                {
                    largestOddNr = nr;
                }
            }

            return largestEvenNr + largestOddNr;
        }

        public static bool IsNumberEven(int nr)
        {
            return nr % 2 == 0;
        }

        public static string RemoveSequencesOfFour(string text)
        {
            char currentLetter = text[0];
            int registeredConsecutives = 1;
            
            for (int i = 1; i < text.Length; i++)
            {
                if (currentLetter.Equals(text[i]) && registeredConsecutives < 3)
                {
                    registeredConsecutives++;
                }
                else if (currentLetter.Equals(text[i]) && registeredConsecutives >= 3)
                {
                    // Om vi innan registrerat tre likadana tecken, då är nuvarande den fjärde 
                    // och vi börjat därmed radera tills upprepningarna tar slut.
                    while (i < text.Length && currentLetter.Equals(text[i]))
                    {
                        text = text.Remove(i, 1);
                    }

                    // Ibland tar loopen ovan bort sista bokstaven i strängen. Därför krävs denna if-sats. 
                    if (i < text.Length)
                    {
                        currentLetter = text[i];
                        registeredConsecutives = 1;
                    }
                    
                }
                else
                {
                    currentLetter = text[i];
                    registeredConsecutives = 1;
                }
            }

            return text;
        }
    }
}
