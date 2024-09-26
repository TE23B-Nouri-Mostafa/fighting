Random generator = new Random();

Console.WriteLine("What's your name?");
string name = Console.ReadLine();



while (name == "" || int.TryParse(name, out int x))
{
    name = Wrongname();
}
Console.Clear();
Console.WriteLine($"Hi {name}!");



static string Wrongname()
{
    Console.SetCursorPosition(0, 0);
    Console.Clear();
    Console.WriteLine("Write your name, idiot!");
    return Console.ReadLine();

}

string monster_name = "THE HOMELESS MONSTER";
Console.WriteLine($"You have been challanged by the coolest guy in the world {monster_name}!!");
Thread.Sleep(2000);

Console.Clear();

int nameHealth = (100);
int monsterHealth = (100);

Console.WriteLine("\nFIGHT");

Console.WriteLine($"{name}: {nameHealth}   {monster_name}: {monsterHealth}");
Console.CursorVisible = false;

while (nameHealth > 0 && monsterHealth > 0)
{

    int name_damage = generator.Next(20);
    monsterHealth -= name_damage;
    monsterHealth = Math.Max(0, monsterHealth);

    Console.SetCursorPosition(name.Length + monster_name.Length + 10, 2);
    Console.Write(monsterHealth + " ");
    // Console.WriteLine($"{name} gör {name_damage} skada på {mosnter_name}");

    Console.SetCursorPosition(0, 4);
    Console.WriteLine("press any key to continue.");
    Console.SetCursorPosition(0, 0);

    int monsterDamage = generator.Next(20);
    nameHealth -= monsterDamage;
    nameHealth = Math.Max(0, nameHealth);

    Console.SetCursorPosition(name.Length + 2, 2);
    Console.Write(nameHealth + " ");
    // Console.WriteLine($"{name} gör {monster_health} skada på {mosnter_name}");



    
    Console.ReadKey();


    Console.SetCursorPosition(0, 0);
}

Console.Clear();

Console.WriteLine("\nTHE Fight is over");

if (nameHealth == 0 && monsterHealth == 0)
{
    Console.WriteLine("draw");
}
else if (nameHealth == 0)
{
    Console.WriteLine($"{monster_name} won!");
}
else
{
    Console.WriteLine($"{name} won!");
}


Console.WriteLine("Press any button to Exit.");
Console.ReadLine();
