internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witam w konwertorze temperatury");
        Console.WriteLine("Proszę wybrać jaką chcesz konwercje : \nC - Celsjusz na Fahrenheit, \nF - Fahrenheit na Celsjusz");
        char wybor = Convert.ToChar(Console.ReadLine());

        if (wybor == 'c' || wybor == 'C')
        {
            Console.WriteLine("Podaj proszę temp :");
            double celcius = Convert.ToDouble(Console.ReadLine());
            double fahrenheit = celcius * 1.8 + 32;
            Console.WriteLine("Ta temp w Farenheitach to : " + fahrenheit);

        }
        else if (wybor == 'f' || wybor == 'F')
        {
            Console.WriteLine("Podaj proszę temp :");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celcius = (fahrenheit - 32) / 1.8;
            Console.WriteLine("Ta temp w Celsjuszach to : " + celcius);
        }
        else
        {
            Console.WriteLine("Wybrałeś błędne opcje");
        }
    }   
}