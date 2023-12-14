using Abstraction.Game;

internal class Program
{
    private static void Main(string[] args)
    {
        Warrior warrior = new Warrior(1);
        Wizard wizard = new Wizard(1);

        warrior.name = "Tor";
        warrior.PrintInfo();       

        warrior.Move();
        warrior.Attack();
        warrior.UseAbility();

        wizard.Attack();
        wizard.Move();
        wizard.UseAbility();

        Console.WriteLine();

        Character[] characters = new Character[3];

        characters[0] = new Wizard(1);
        characters[1] = new Warrior(1);
        characters[2] = new Warrior(3);

        foreach(var character in characters)
        {
            character.Attack();
            character.Attack();
            character.PrintInfo();
        }
    }
}