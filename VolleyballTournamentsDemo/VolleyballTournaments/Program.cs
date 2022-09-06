using System;

namespace VolleyballTournaments
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<string> hold = new List<string>
            {
                "Hold-1",
                "Hold-2",
                "Hold-3",
                "Hold-4",
                "Hold-5"
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1\t:Alle 5 hold skal spille to kampe mod hvert hold.\n" +
                    "2\t:Hvert hold spiller kun én kamp mod hvert af de andre hold.\n" +
                    "3\t:Brugeren kan selv vælge, hvor mange hold, der skal deltage i turneringen.\n" +
                    "Esc\t:Luk programmet.\n");

                Console.WriteLine("Indtast 1, 2 eller 3 for at se løsningen til den del af opgaven.\n" +
                    "Tryk på Esc for at afslutte.\n");

                ConsoleKeyInfo csi = new();
                csi = Console.ReadKey(true);

                byte count = 1;
                if (csi.Key == ConsoleKey.D1 || csi.Key == ConsoleKey.NumPad1)
                {
                    for (int i = 0; i < hold.Count; i++)
                    {
                        for (int j = i+1; j < hold.Count; j++)
                        {
                            Console.WriteLine($"Kamp nr. {count++}:\t {hold[i]} vs {hold[j]}");
                            Console.WriteLine($"Kamp nr. {count++}:\t {hold[j]} vs {hold[i]}");
                        }
                    }
                    Console.ReadLine();
                }
                else if (csi.Key == ConsoleKey.D2 || csi.Key == ConsoleKey.NumPad2)
                {
                    for (int i = 0; i < hold.Count; i++)
                    {
                        for (int j = i + 1; j < hold.Count; j++)
                        {
                            Console.WriteLine($"Kamp nr. {count++}:\t {hold[i]} vs {hold[j]}");
                        }
                    }
                    Console.ReadLine();
                }
                else if (csi.Key == ConsoleKey.D3 || csi.Key == ConsoleKey.NumPad3)
                {
                    bool bol = false;
                    int antalHold = 0;
                    do
                    {
                        try
                        {
                            Console.Write("Indtast antal hold som skal deltage i turneringen :");
                            antalHold = int.Parse(Console.ReadLine());
                            if (antalHold > 1)
                            {
                                bol = true;
                            }
                            else
                            {
                                bol = false;
                            }
                        }
                        catch (Exception)
                        {
                            bol = false;
                        }
                    } while (!bol);
                    for (int i = 0; i < antalHold; i++)
                    {
                        for (int j = i + 1; j < antalHold; j++)
                        {
                            Console.WriteLine($"Kamp nr. {count++}:\t Hold-{i+1} vs Hold-{j+1}");
                        }
                    }
                    Console.ReadLine();
                }
                else if (csi.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Programmet lukker ned");
                    Environment.Exit(0);
                }
            }
        }
    }
}