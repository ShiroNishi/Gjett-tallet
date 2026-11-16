namespace Emne3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var number = random.Next(1, 100);
            var result = 101;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Du har " + (10 - i) + " forsøk igjen");
                if (i == 9)
                {
                    Console.WriteLine("Du har tapt, tallet var " + number);
                    break;
                }

                Console.WriteLine("Gjett det hemmelige tallet fra 1 til 100");
                Console.WriteLine("Skriv ditt nummer");

                var input = Console.ReadLine();

                result = Convert.ToInt32(input);
                Console.WriteLine(result);
                Console.WriteLine("Du skrev " + input);
                if (result == number)
                {
                    Console.WriteLine("Du gjettet riktig");
                }
                else
                {
                    Console.WriteLine("Du gjettet feil :(");
                }

            }

        }
    }
}