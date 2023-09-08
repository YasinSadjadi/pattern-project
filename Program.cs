namespace pattern_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter 4 number to detect the pattern");
            Console.WriteLine("first number : ");
            string a1 = Console.ReadLine();
            Console.WriteLine("second number : ");
            string a2 = Console.ReadLine();
            Console.WriteLine("third number : ");
            string a3 = Console.ReadLine();
            Console.WriteLine("forth number : ");
            string a4 = Console.ReadLine();
            int a1N;
            int a2N;
            int a3N;
            int a4N;
            bool a1C = int.TryParse(a1, out a1N);
            bool a2C = int.TryParse(a2, out a2N);
            bool a3C = int.TryParse(a3, out a3N);
            bool a4C = int.TryParse(a4, out a4N);
            if ((a1C = true) && (a2C = true) && (a3C = true) && (a4C = true))
            {
                int d1 = a2N - a1N;
                int d2 = a3N - a2N;
                int d3 = a4N - a3N;
                int q1 = a2N / a1N;
                int q2 = a4N / a3N;
                int r1 = d2 - d1;
                int r2 = d3 - d2;

                if (d1 == d2)
                {
                    for (int i = a4N; i < 100; i = i + d1)
                    {
                        Console.WriteLine(i);
                    }
                }
                else if (q1 == q2)
                {
                    for (int i2 = a4N; i2 < 100; i2 = i2 * q1)
                    {
                        Console.WriteLine(i2);
                    }
                }
                else if (r1 == r2)
                {
                    int i3 = d3;
                    int i4 = a4N;
                    do
                    {
                        i3 = i3 + r1;
                        i4 = i4 + i3;
                        Console.WriteLine(i4);



                    } while (i4 < 100);
                }
            }
            else
            {
                Console.Clear();
                Console.Title = "error";
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("wrong input");
                Console.ResetColor();
                Console.ReadKey();
            }

        }
    }
}