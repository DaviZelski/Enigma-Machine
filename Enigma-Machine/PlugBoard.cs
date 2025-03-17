using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma_Machine
{
    class PlugBoard
    {
        //missing methods: remove-pair, reset()

        private Dictionary<char, char> _plugboardConnections = new Dictionary<char, char>();



        public void SetupPlugboard()
        {


            bool ready = false;

            while (!ready)
            {
                Console.WriteLine("How many pairs do wish to create? (Maximum is 10!)");
                int pairAmount = int.Parse(Console.ReadLine());

                switch (pairAmount)
                {
                    case <= 10:
                        AddPairs(pairAmount);
                        ready = true;
                        break;

                    case > 10:
                        Console.WriteLine("The maximum number of pairs allowed is of 10 pairs!\n");
                        break;

                    default:
                        Console.WriteLine("Incorrect input. Please try again\n");
                        break;
                }

            }


        }


        private void AddPairs(int pairAmount)
        {

            int i = 0;
            while (i < pairAmount)
            {

                bool isValidSwitch = false;
                while (!isValidSwitch)
                {
                    Console.WriteLine("Please type the letter pair you want to add in this format: Letter1,Letter2\n");
                    string pairInput = Console.ReadLine();
                    pairInput = pairInput.Trim('(', ')');
                    string[] pairCharacters = pairInput.Split(',');

                    char Key = pairCharacters[0][0];
                    char Value = pairCharacters[1][0];

                    Key = char.ToLower(Key);
                    Value = char.ToLower(Value);

                    if (IsValid(Key, Value))
                    {
                        _plugboardConnections.Add(Key, Value);
                        _plugboardConnections.Add(Value, Key);
                        isValidSwitch = true;
                        ShowPairs();
                    }
                    i++;

                }

            }
            Console.WriteLine($"All {_plugboardConnections.Count() / 2} pairs of letters were added!\n");

        }



        private bool IsValid(char TKey, char TValue)
        {
            if (TKey == TValue)
            {
                Console.WriteLine("A letter cannot be switched with itself!\n");
                return false;
            }
            else if (_plugboardConnections.ContainsKey(TKey))
            {
                Console.WriteLine($"The letter {TKey} is already mapped to {_plugboardConnections[TKey]}! Please choose a different pair.\n");
                return false;
            }
            else if (_plugboardConnections.ContainsKey(TValue))
            {
                Console.WriteLine($"The letter {TValue} is already mapped to {_plugboardConnections[TValue]}! Please choose a different pair.\n");
                return false;
            }

            Console.WriteLine($"The letters {TKey} and {TValue} will now be switched!\n");
            return true;
        }


        private void ShowPairs()
        {
            HashSet<char> displayed = new HashSet<char>();
            Console.WriteLine("-------------------\nCurrent Pairs:\n");
            foreach (var pair in _plugboardConnections)
            {
                
                char key = pair.Key;
                char value = pair.Value;

                // Ensure we only print each pair once
                if (!displayed.Contains(key) && !displayed.Contains(value))
                {
                    Console.WriteLine($"{{ {key}, {value} }}\n");
                    displayed.Add(key);
                    displayed.Add(value);
                }
            }
            Console.WriteLine("--------------------\n");
        }

        
        public string Swap(string oMessage)
        {
            oMessage = oMessage.ToLower();
            int mLength = oMessage.Length;
            StringBuilder eMessage = new StringBuilder();

            if (_plugboardConnections.Count == 0)
            {
                Console.WriteLine("No connection on the PLugboard,no letters were swapped!\n");
                return oMessage;

            } else
            {
                

                for(int i = 0; i < mLength; i++)
                {
                    char charTS = oMessage[i];

                    if (_plugboardConnections.ContainsKey(charTS))
                    {
                        char charSP = _plugboardConnections[charTS];
                        eMessage.Append(charSP);
                    }
                    else
                    {
                        eMessage.Append(oMessage[i]);

                    }

                }
            }



            return eMessage.ToString();
        }

    }
}
