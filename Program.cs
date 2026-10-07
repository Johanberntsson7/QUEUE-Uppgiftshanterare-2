namespace QUEUE_Uppgiftshanterare_2;

class Program
{
    static void Main(string[] args)
    {
        // Lära sig hantera data i rätt ordning (FIFO – First In, First Out).

        // 💻 Uppgift:
        // Implementera ett enkelt uppgiftshanteringssystem med Queue<string>.
        Queue<string> uppgifter = new Queue<string>();

        uppgifter.Enqueue("Uppgifter 1");
        uppgifter.Enqueue("Uppgifter 2");
        uppgifter.Enqueue("Uppgifter 3");
        

        bool kör = true;

        while (kör)
        {   
            Console.WriteLine("-------UPPGIFSTKÖ-------");
            Console.WriteLine("1. Lägga till uppgifter i kön");
            Console.WriteLine("2. Visa nästa uppgift (utan att ta bort den)");
            Console.WriteLine("3. Slutföra nästa uppgift");
            Console.WriteLine("4. Visa alla återstående uppgifter i kön");
            Console.WriteLine("5. Avsluta");
            Console.Write("Välj: ");

            string val = Console.ReadLine()!;
            Console.WriteLine(val);

            switch (val)
            {
                case "1":
                    Console.Write("Skriv in ny uppgift: ");
                    string nyUppgift = Console.ReadLine()!;
                    uppgifter.Enqueue(nyUppgift);
                    Console.WriteLine($"'{nyUppgift}' lades till i kön.");
                    break;

                case "2":
                    if (uppgifter.Count > 0)
                    {
                        Console.WriteLine("Visa nästa uppgift");
                        Console.WriteLine(uppgifter.Peek());
                    }
                    else
                    {
                        Console.WriteLine("Kön är tom.");
                    }
                    break;

                case "3":
                    if (uppgifter.Count > 0)
                    {
                        Console.WriteLine("Slutför en uppgift");
                        string uppgiftklar = uppgifter.Dequeue();
                        Console.WriteLine($"Slutförd: {uppgiftklar}");
                    }
                    else
                    {
                        Console.WriteLine("Det finns inga uppgifter att slutföra.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Återstående uppgifter:");
                    if (uppgifter.Count == 0)
                    {
                        Console.WriteLine("Kön är tom.");
                    }
                    else
                    {
                        foreach (var uppgift in uppgifter)
                        {
                            Console.WriteLine(uppgift);
                        }
                    }
                    break;

                case "5":
                    kör = false;
                    Console.WriteLine("Programmet avslutas.");
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
            Console.WriteLine("Tryck på valfri tangent för att forsätta");
            Console.ReadKey();
        }

        // I menyn ska användaren kunna:
        // ➕ Lägga till nya uppgifter i kön (Enqueue).
        // 👀 Visa nästa uppgift utan att ta bort den (Peek).
        // ✅ Slutföra en uppgift – ta bort den översta (Dequeue) och visa vilken som slutförts.
        // 📋 Visa alla återstående uppgifter i kön.

        // 💡 Tips:
        // Använd while (queue.Count > 0) för att visa alla.
        // Förklara skillnaden mellan Peek() och Dequeue().
    }
}
