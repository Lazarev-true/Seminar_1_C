Console.WriteLine("Ввод трёх чисел");
Console.Write("Введите первое число (Десятичные через запятую): ");
string first = Console.ReadLine();
double firstnumber = Convert.ToDouble(first);
 
Console.Write("Введите второе число (Десятичные через запятую): ");
string second = Console.ReadLine();
double secondnumber = Convert.ToDouble(second);

Console.Write("Введите третье число (Десятичные через запятую): ");
string third = Console.ReadLine();
double thirdnumber = Convert.ToDouble(third);

double max = firstnumber;

if(secondnumber > max) max = secondnumber;
if(thirdnumber > max) max = thirdnumber;

Console.WriteLine("Максимальное из этих чисел: " + max);