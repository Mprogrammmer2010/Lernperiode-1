using System;

class Program
{
    static void Main()
    {
        double zahl = 42;
        double tipp;
        bool gewonnen = false;

        Console.WriteLine("Zahlenratespiel");
        Console.WriteLine("Rate die Zahl zwischen 1 und 100!");

        while (gewonnen == false)
        {
            Console.Write("Dein Tipp: ");
            tipp = Convert.ToDouble(Console.ReadLine());

            if (tipp == zahl)
            {
                Console.WriteLine("Richtig! Du hast gewonnen!");
                gewonnen = true;
            }
            else if (tipp < zahl)
            {
                Console.WriteLine("Die Zahl ist größer.");
            }
            else
            {
                Console.WriteLine("Die Zahl ist kleiner.");
            }
        }

        Console.WriteLine("Spiel beendet!");
        Console.ReadLine();
    }
}