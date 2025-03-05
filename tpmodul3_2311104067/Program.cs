using System;

class Program
{
    static void Main()
    {
        DoorMachine door = new DoorMachine(); 

        while (true)
        {
            Console.Write("\nMasukkan perintah ('Terbuka' atau 'Terkunci'): ");
            string input = Console.ReadLine();

            if (input.Equals("Terbuka", StringComparison.OrdinalIgnoreCase) ||
                input.Equals("Terkunci", StringComparison.OrdinalIgnoreCase))
            {
                door.ChangeState(input);
            }
            else
            {
                Console.WriteLine("Program selesai.");
                break;
            }
        }
    }
}
