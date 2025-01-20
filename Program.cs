namespace Set2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti cate elemente doriti sa aiba secventa de numere: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Introdu un nr a: ");
            int a = int.Parse(Console.ReadLine());

            int element;
            int pozitie = -1;
            int pozitieA = -1;
            for(int i = 0; i < n; i++)
            {
                element = int.Parse(Console.ReadLine());
                pozitie++;
                if(element == a)
                {
                    pozitieA = pozitie;
                    
                }  
            }
            if(pozitieA == -1)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine($"Numarul {a} se afla pe pozitia {pozitieA}");
            }
        }
    }
}
