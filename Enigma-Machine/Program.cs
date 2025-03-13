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

            PlugBoard plugboard = null;
            if (plugUse == 'y') {

                Console.WriteLine("Board will be used.\n");
                plugboard = new PlugBoard();
                plugboard.SetupPlugboard();
            }
            else {
                Console.WriteLine("Board will not be used\n");
            }
                
                    
            

            Console.WriteLine($"{Message}");



            Console.ReadLine();
        }

        static void Encrypt() { 
        
        }
    }
}
