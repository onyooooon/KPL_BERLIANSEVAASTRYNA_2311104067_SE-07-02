using System;

public class DoorMachine
{
    private enum State { Terkunci, Terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void ChangeState(string input)
    {
        if (input.Equals("Terbuka", StringComparison.OrdinalIgnoreCase))
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci");
            }
            else
            {
                Console.WriteLine("Pintu terkunci");
            }
        }
        else if (input.Equals("Terkunci", StringComparison.OrdinalIgnoreCase))
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci");
            }
            else
            {
                Console.WriteLine("Pintu terkunci");
            }
        }
        else
        {
            Console.WriteLine("Input tidak valid! Masukkan 'Terbuka' atau 'Terkunci'.");
        }
    }
}
