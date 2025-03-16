namespace Enigma_Machine
{
    internal class Program



    {
        static void Main()
        {
            Console.WriteLine("Enigma Machine started! Type your message for encryption:");
            string Message = Console.ReadLine();
            
            Console.WriteLine("Do you wish to use the plugboard? y/n");
            char plugUse = char.Parse(Console.ReadLine());
            plugUse = char.ToLower(plugUse);

            if (plugUse == 'y') {

                Console.WriteLine(
                    "-------------------------------------------------\n" +
                    "The plugboard is an optional setting that\n" +
                    "allows for a pair of letters to be switched\n" +
                    "between themselves! The historical limit is of\n" +
                    "10 pairs (20 letters). Do you wish to confirm?\n" +
                    "-------------------------------------------------\n"
                    );
                bool i = false;
                while (!i)
                {
                    Console.WriteLine("1)Confirm\n2)I've changed my mind\n");
                    int input = int.Parse(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("Plugboard will be used.\n");
                            PlugBoard plugboard = new PlugBoard();
                            plugboard.SetupPlugboard();
                            i = true;
                            break;

                        case 2:
                            Console.WriteLine("Plugboard will not be used\n");
                            i = true;
                            break;

                        default:
                            Console.WriteLine("Please select options between 1 and 2\n");
                            break;
                    }
                }

                
            }
            else {
                Console.WriteLine("Plugboard will not be used\n");
            }
                
            Console.WriteLine($"Encrypted message: {Message}");



            Console.ReadLine();
        }

        static void Encrypt() { 
        
        }
    }
}
