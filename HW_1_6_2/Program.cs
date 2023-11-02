//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Використовуючи цикли та метод: Console.Write("*"), Console.Write(" "), Console.Write("\n")(для переходу на новий рядок).Виведіть на екран:

// прямокутник
// прямокутний трикутник
// рівносторонній трикутник
// ромб



namespace HW_1_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number first A");
            var inputA = Console.ReadLine();
            int.TryParse(inputA, out int A);

            Console.WriteLine("Enter number second B");
            var inputB = Console.ReadLine();
            int.TryParse(inputB, out int B);
            
            Console.WriteLine("-----------------------------------------------------------------");
            
            //Прямокутник

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("-----------------------------------------------------------------");
            
            //Прямокутний трикутник
            
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("-----------------------------------------------------------------");
            
            //Рівносторонній трикутник
            
            int D = B;

            int C = 1;
            
            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B ; j++)
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < C; k++)
                {
                    Console.Write("*");
                }

                B -= 1;
                C += 2;
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------");
            
            //Ромб

            C = 1;
            
            //int D = B;

            for (int i = 0; i < (A + A + 1); i++)
            {
                if (i < A)
                {
                    for (int j = 0; j < D; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < C; k++)
                    {
                        Console.Write("*");
                    }

                    D -= 1;
                    C += 2;
                    Console.WriteLine();
                }
                else
                {
                    for (int j = 0; j < D; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int k = 0; k < C; k++)
                    {
                        Console.Write("*");
                    }

                    D += 1;
                    C -= 2;
                    Console.WriteLine();
                }
            }
        }
    }
}