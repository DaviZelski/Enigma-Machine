namespace Enigma_Machine
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enigma Machine started!");
            string message = GetMessageFromUser();
            PlugBoard? plugboard = ConfigurePlugboard();

            string encryptedMessage = plugboard.Swap(message);
            Console.WriteLine($"Encrypted message: {encryptedMessage}");

            Console.ReadLine();
        }

        static string GetMessageFromUser()
        {
            Console.WriteLine("Type your message for encryption:");
            return Console.ReadLine();
        }

        static PlugBoard? ConfigurePlugboard()
        {
            Console.WriteLine("Do you wish to use the plugboard? (y/n)");
            char plugUse = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine(); 

            if (plugUse == 'y')
            {
                Console.WriteLine(
                    "-------------------------------------------------\n" +
                    "The plugboard allows swapping letter pairs.\n" +
                    "The historical limit is 10 pairs (20 letters).\n" +
                    "-------------------------------------------------"
                );

                while (true)
                {
                    Console.WriteLine("1) Confirm\n2) I've changed my mind");
                    if (int.TryParse(Console.ReadLine(), out int input))
                    {
                        if (input == 1)
                        {
                            Console.WriteLine("Plugboard will be used.");
                            PlugBoard plugboard = new PlugBoard();
                            plugboard.SetupPlugboard();
                            return plugboard;
                        }
                        else if (input == 2)
                        {
                            Console.WriteLine("Plugboard will not be used.");
                            return null; 
                        }
                    }
                    Console.WriteLine("Invalid input. Please select 1 or 2.");
                }
            }

            Console.WriteLine("Plugboard will not be used.");
            return null;
        }

        
    }
}
