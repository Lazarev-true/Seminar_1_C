Console.Write("Введите число: ");
string first = Console.ReadLine();
int N = Convert.ToInt32(first);
int i = 2;
Console.Write(N + " -> ");
while(i <= N)
{
    Console.Write(i + ", ");
    i += 2;    
}
