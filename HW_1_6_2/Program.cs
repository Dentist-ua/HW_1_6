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
            
            //Прямокутник

            for (int i = 0; i < A; i++)
            {
                for (int j = 0; j < B; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            
            
        }
    }
}