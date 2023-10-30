namespace BugProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HUOM! Poista tehtävän alla oleva return, kun olet korjannut bugin, jotta voit tehdä seuraavaa tehtävää

            Console.WriteLine("Syötä etunimi");
            string firstName = Console.ReadLine();
            Console.WriteLine("Syötä sukunimi");
            string lastName = Console.ReadLine();

            //Tehtävä 1: Korjaa funktion, jotta se tulostaa oikein koko nimen
            PrintFullName(firstName, lastName);

            return;

            //Tehtävä 2: Korjaa funktio nolllala jaettavien lukujen kohdalla. 
            //Jos nollalla yritää jakaa, niin silloin funktion pitäisi palauttaa -1
            double result = Divide(12, 0);

            return;

            int[] numbers = { 1, 2, 3, 4, 5 };

            //Tehtävä 3: Korjaa funktion, jotta se laskee oikein keskiarvon
            double average = CalculateAverage(numbers);

            return;

            Console.WriteLine("Syötä ikä");
            int age = int.Parse(Console.ReadLine());

            //Tehtävä 4; Korjaa funktion, jotta se tulostaa oikean sukupolven, jos ikä on 59
            DeterminiteGeneration(age);

            return;

            //Tehtävä 5: Korjaa funktio toimivaksi
            PrintPlanetNames();

            return;

        }

        public static void PrintFullName(string firstName, string lastName)
        {
            Console.WriteLine(firstName + lastName);
        }

        public static double CalculateAverage(int[] numbers)
        {
            double sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum / numbers.Length;
        }

        public static double Divide(int a, int b)
        {
            if(a == 0 && b == 0)
            {
                return -1;
            }
            else
            {
                return a / b;
            }
        }

        public static void DeterminiteGeneration(int age)
        {
            if (age >= 0 && age <= 13)
            {
                Console.WriteLine("Kuulut Gen Alpha (Alpha) sukupolveen.");
            }
            else if (age >= 14 && age <= 28)
            {
                Console.WriteLine("Kuulut Gen Z (Z-sukupolvi) sukupolveen.");
            }
            else if (age >= 29 && age >= 43)
            {
                Console.WriteLine("Kuulut Millennials (Y) sukupolveen.");
            }
            else if (age >= 44 || age <= 58)
            {
                Console.WriteLine("Kuulut Gen X (X-sukupolvi) sukupolveen.");
            }
            else if (age >= 59 && age <= 77)
            {
                Console.WriteLine("Kuulut Baby Boomers sukupolveen.");
            }
            else
            {
                Console.WriteLine("Et kuulu mihinkään yllä mainituista sukupolvista tässä ohjelmassa.");
            }
        }

        public static void PrintPlanetNames()
        {
            string[] planets = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            for (int i = 0; i <= planets.Length; i++)
            {
                Console.WriteLine(planets[i]);
            }
        }

    }
}