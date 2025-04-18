
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witam w kalkulatorze !\nCo chczesz zrobić ?\n1.Sumowanie\n2.Odejmowanie\n3.Mnożenie\n4.Dzielenie");
        char wybor = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Prosze podać pierwsza liczbe :");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Prosze podać Drugą liczbe :");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (wybor == '1')
        {
            double wynik = num1 + num2;
            Console.WriteLine(wynik);
        }
        else if(wybor == '2')
        {
            double wynik = num1 - num2;
            Console.WriteLine(wynik);
        }
        else if (wybor == '3')
        {
            double wynik = num1 * num2;
            Console.WriteLine(wynik);
        }
        else if (wybor == '4')
        {
            if(num1 != 0 || num2 != 0)
            {
                Console.WriteLine("Nie dzielimy przez zero");
            }
            else 
            {
                double wynik = num1 / num2;
                Console.WriteLine(wynik);
            }
        }
        else
        {
            Console.WriteLine("Prosze podac wybor od 1 do 4");
        }
    }
}