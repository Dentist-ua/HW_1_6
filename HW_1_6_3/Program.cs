
Console.WriteLine("Enter number of client");
var inputA = Console.ReadLine();
int.TryParse(inputA, out int client);
            
Console.WriteLine("-----------------------------------------------------------------");

int result = 1;
do
{
    result *= client--;
}
while(client > 0);

Console.WriteLine($"Number {result}");

