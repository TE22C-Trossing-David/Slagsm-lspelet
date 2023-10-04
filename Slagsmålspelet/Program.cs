int health1 = 100;
int health2 = 100;
int damage = 0;
int round = 0;
string namePlayer1 = "";
string namePlayer2 = "";
Random random = new Random();
int num = random.Next();
int healing = 0;
int sheildRound1 = 0;
int sheildRound2 = 0;
string action = "";

while (true)
{
    Console.WriteLine("Vad heter Spelare 1?");
    namePlayer1 = Console.ReadLine();
    Console.WriteLine("Vad heter Spelare 2?");
    namePlayer2 = Console.ReadLine();
    Console.WriteLine("När du slår gör du från 5-20 damage, När du healar får du du 1-30 health och när du blockar så tar du 1/2 damage i 2 rundor. Begript?");
    Console.ReadLine();
    Console.WriteLine(namePlayer1 + " och " + namePlayer2 + " är ni redo?");
    Console.ReadLine();
    Console.WriteLine("jag bryr mig inte, Börja fighta");

    while (true)
    {
        if (sheildRound1 <= 0)
        {

            sheildRound1--;
        }

        if (sheildRound2 <= 0)
        {

            sheildRound2--;
        }
        //Damage P1
        Console.WriteLine( namePlayer1"\n1. Slå, 2. Heal, 3. Block");
        action = Console.ReadLine();
        if (action == "1")
        {
            damage = random.Next(5, 20);
            health2 -= damage;
            Console.WriteLine();
            if (sheildRound2 <= 0)
            {
                health2 += damage / 2;
            }
            Console.WriteLine("Du gjorde " + damage + " och han har " + health2 + " HP");
            Console.ReadLine();
        }
        //Heal P1
        if (action == "2")
        {
            healing = random.Next(1, 30);
            health1 += healing;
            Console.WriteLine("Du fick " + healing + " och har " + health1 + " HP");
            Console.ReadLine();
        }
        //Block P1
        if (action == "3")
        {
            sheildRound1 = 2;
            Console.WriteLine("Du har nu sheild i 2 rundor");
            Console.ReadLine();
        }

        //Damage P2

        Console.WriteLine( namePlayer2"\n1. Slå, 2. Heal, 3. Block");
        action = Console.ReadLine();
        if (action == "1")
        {
            damage = random.Next(5, 20);
            health2 -= damage;
            Console.WriteLine();
            if (sheildRound2 <= 0)
            {
                health2 += damage / 2;
            }
            Console.WriteLine("Du gjorde " + damage + " och han har " + health2 + " HP");
            Console.ReadLine();
        }
        //Heal P2
        if (action == "2")
        {
            healing = random.Next(1, 30);
            health1 += healing;
            Console.WriteLine("Du fick " + healing + " och har " + health1 + " HP");
            Console.ReadLine();
        }
        //Block P2
        if (action == "3")
        {
            sheildRound1 = 2;
            Console.WriteLine("Du har nu sheild i 2 rundor");
            Console.ReadLine();
        }
    }


}