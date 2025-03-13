using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    class PlugBoard
    {
        private Dictionary<char, char> _plugboardConnections = new Dictionary<char, char>();

        public void SetupPlugboard()
        {

            int amountOfLetters = 1;
            bool acceptedSwap = false;
            Console.WriteLine("How many letters will be swapped? (in multiples of 2, since the swap is between two letters. Max is 26)");
            while ((amountOfLetters % 2) != 0 && !acceptedSwap)
            {
                amountOfLetters = int.Parse(Console.ReadLine());

                if (amountOfLetters < 2)
                {
                    Console.WriteLine("Number too low, minimum is 2!");
                }
                else if (amountOfLetters % 2 != 0)
                {
                    Console.WriteLine("Number must be a multiple of 2!");
                }
                else if (amountOfLetters > 26)
                {
                    Console.WriteLine("Number must not be higher than the amount of letters in the alphabet!");
                }
                else if (amountOfLetters >= 2 && amountOfLetters <= 26)
                {
                    Console.WriteLine($"Swapping {amountOfLetters} letters!");

                    for (int i = 0; i < (amountOfLetters / 2); i++)
                    {
                        Console.WriteLine("Please input which letters will be swapped in this format: (OriginalLetter,LetterToSwap)");
                        string input = Console.ReadLine();

                        input = input.Trim('(', ')');
                        string[] letters = input.Split(',');

                        char originalLetter = letters[0][0];
                        char letterToSwap = letters[1][0];

                        Console.WriteLine($"Letters {originalLetter} and {letterToSwap} have been swapped!");

                        // Implement actual swapping with dictionary here...
                        acceptedSwap = true;
                    }

                    
                }
            }



        }
    }
}
