Console.Write("Введите число: ");
string first = Console.ReadLine();
int N = Convert.ToInt32(first);
int i = 0;
int M = N;
Console.Write(N + " -> ");
N = N / 2 * 2;
while(N != 0)
{
    if(N > 0) 
    {
        i += 2;
        Console.Write(i);
        N -= 2;
    }
    
    else
    {
        i -= 2;
        Console.Write(i);
        N += 2;
    }

    if(Math.Abs(i) < (Math.Abs(M) - 2)) Console.Write(", ");
}
