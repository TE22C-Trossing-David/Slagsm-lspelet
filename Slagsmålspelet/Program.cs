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
bool ingenDed = true;

while (ingenDed = true)
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
        if (sheildRound1 > 0)
        {
            sheildRound1--;
            Console.WriteLine("");
            Console.WriteLine(namePlayer1 + " Du har sheild i " + sheildRound1 + " rundor till");
        }

        //Damage P1
        Console.WriteLine("");
        Console.WriteLine(namePlayer1 + "\n1. Slå, 2. Heal, 3. Block");
        action = Console.ReadLine();
        if (action == "1")
        {
            damage = random.Next(5, 20);
            health2 -= damage;
            if (sheildRound2 > 0)
            {
                health1 += damage / 2;
                Console.WriteLine("Yanni " + namePlayer2 + " blockade och tog bara " + damage / 2 + ". Hans nya hp är " + health2);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Du gjorde " + damage + " och " + namePlayer2 + " har " + health2 + " HP");
                Console.ReadLine();
            }
        }
        //Heal P1
        if (action == "2")
        {
            healing = random.Next(1, 30);
            health1 += healing;
            if (health1 > 100)
            {
                health1 = 100;
                Console.WriteLine("You now have max HP");
                Console.ReadLine();
            }
            else
            {

                Console.WriteLine("Du fick " + healing + " och har " + health1 + " HP");
                Console.ReadLine();
            }
        }
        //Block P1
        if (action == "3")
        {
            sheildRound1 = 2;
            Console.WriteLine("Du har nu sheild i 2 rundor");
            Console.ReadLine();
        }

        deathCheck();






        if (sheildRound2 > 0)
        {
            sheildRound2--;
            Console.WriteLine("");
            Console.WriteLine(namePlayer2 + "- Du har sheild i " + sheildRound2 + " rundor till");
        }
        //Damage P2
        Console.WriteLine("");
        Console.WriteLine(namePlayer2 + "\n1. Slå, 2. Heal, 3. Block");
        action = Console.ReadLine();
        if (action == "1")
        {
            damage = random.Next(5, 20);
            health1 -= damage;
            if (sheildRound1 > 0)
            {
                health1 += damage / 2;
                Console.WriteLine("Yanni " + namePlayer1 + " blockade och tog bara " + damage / 2 + ". Hans nya hp är " + health1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Du gjorde " + damage + " och " + namePlayer1 + " har " + health1 + " HP");
                Console.ReadLine();
            }
        }
        //Heal P2
        if (action == "2")
        {
            healing = random.Next(1, 30);
            health2 += healing;
            if (health2 > 100)
            {
                health2 = 100;
                Console.WriteLine("You now have max HP");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Du fick " + healing + " och har " + health2 + " HP");
                Console.ReadLine();
            }
        }
        //Block P2
        if (action == "3")
        {
            sheildRound2 = 2;
            Console.WriteLine("Du har nu sheild i 2 rundor");
            Console.ReadLine();
        }
    }


}

ingenDed = true;

void deathCheck()
{
    if (health1 <= 0)
    {
        Console.WriteLine("NÅGON DOG YANNI!!!");
        ingenDed = false;
    }
}