//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Дано два числа A та B (A<B) виведіть суму всіх чисел розташованих між цими числами на екран.
//Дано два числа A та B (A<B) виведіть усі непарні значення, розташовані між даними числами



namespace HW_1_6_1
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

            int result = 0;

            for (A = A + 1; A < B; A++)
            {
                result = result + A;
            }

            Console.WriteLine($"Sum of the numbers between {inputA} to {inputB} is {result}");
            Console.WriteLine("-----------------------------------------------------------------");
                        
            int.TryParse(inputA, out int C);
                        
            int.TryParse(inputB, out int D);

            for (C = C + 1; C < D; C++)
            {
                if (C % 2 != 0)
                {
                    Console.WriteLine($"Not an even number {C}");
                }
            }
            Console.ReadKey();
        }
    }
}