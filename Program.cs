namespace Set2ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti cate elemente doriti sa aiba secventa de numere: ");
            int n = int.Parse(Console.ReadLine());

            int[] v = new int[n];

            Console.WriteLine("Introduceti elementele vectorului: ");
            for (int i = 0; i < n; i++)
            {
                 v[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("intrudu un numar a: ");
            int a = int.Parse(Console.ReadLine());

            if (v.Contains(a))
            {
                for(int i = 0;i < v.Length; i++)
                {
                    if (v[i] == a)
                    {
                        Console.WriteLine($"Pozitia pe care se afla a este: {i}");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine(-1);
            }

        }
    }
}
