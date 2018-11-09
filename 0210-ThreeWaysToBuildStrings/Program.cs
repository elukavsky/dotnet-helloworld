using System;

class Program
{
    static void Main()
    {
        int damageTaken = 100;
        string nameOfCharacter = "Tod";
        string spellName = "fireball";

        string damageReport = nameOfCharacter + " took " + damageTaken + " damage from " + spellName;
        Console.WriteLine(damageReport);

        string damageReportV2 = string.Format("{0} took {1} damage from {2}", nameOfCharacter, damageTaken, spellName);
        Console.WriteLine(damageReportV2);

        string damageReportV3 = string.Format("{0} took {1} damage from {2}. {0} is now dead.", nameOfCharacter, damageTaken, spellName);
        Console.WriteLine(damageReportV3);

        string damageReportV4 = $"{nameOfCharacter} took {damageTaken} damage from {spellName}. {nameOfCharacter} is now dead.";
        Console.WriteLine(damageReportV4);
    }
}