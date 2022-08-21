Console.Write("Введите число: ");
string first = Console.ReadLine();
int number = Convert.ToInt32(first);

int N = number % 2;

if(N == 0) Console.Write("Число чётное");
if(N != 0) Console.Write("Число не чётное");