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


        private void AddPairs(int pairAmount)
        {
            for (int i = 0; i < pairAmount; i++)
            {

                char Key = 's'; // placeholder
                char Value = 's'; // placeholder

                Key = char.ToLower(Key);
                Value = char.ToLower(Value);
                _plugboardConnections.Add(Key, Value);
            }
        }

        public void SetupPlugboard()
        {

            


            bool ready = false;
            
            while (!ready)
            {
                Console.WriteLine("How many pairs do wish to create? (Maximum is 10!)");
                int pairAmount = int.Parse(Console.ReadLine());

                switch (pairAmount)
                {
                    case > 10:
                        AddPairs(pairAmount);
                        break;
                }

            }


        }
    }
}
