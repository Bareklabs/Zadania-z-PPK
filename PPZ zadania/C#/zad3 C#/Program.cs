internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Witam w aplikacji,która oblicza średnią ocen uczniów\n");
        Console.WriteLine("Proszę podać ile oczen uczeń ma : ");

        int liczbaOcen = Convert.ToInt32(Console.ReadLine());
        double suma = 0;

        for (int i=0; i<liczbaOcen ; i++)
        {
            Console.WriteLine($"Podaj {i+1} ocene :");
            double ocena = Convert.ToDouble(Console.ReadLine());
            suma += ocena; 
        }

        double srednia = suma / liczbaOcen;
        Console.WriteLine($"Średnia ocen to : {srednia}\n");

        if (srednia>=3.0)
        {
            Console.WriteLine("Uczeń zdał!");
        }
        else
        {
            Console.WriteLine("Uczeń nie zdał!");
        }
    }
}