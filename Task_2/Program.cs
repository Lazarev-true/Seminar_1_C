Console.WriteLine("Ввод двух чисел");
Console.Write("Введите первое число (Десятичные через запятую): ");
string first = Console.ReadLine();
double firstnumber = Convert.ToDouble(first);
 
Console.Write("Введите второе число (Десятичные через запятую): ");
string second = Console.ReadLine();
double secondnumber = Convert.ToDouble(second);

if(firstnumber > secondnumber)
{
    double max = firstnumber;
    double min = secondnumber;
    Console.WriteLine("Больше: " + max + " Меньше: " + min);
}

if(secondnumber > firstnumber)
{
    double max = secondnumber;
    double min = firstnumber;
    Console.WriteLine("Больше: " + max + " Меньше: " + min);
}
else
{
   Console.WriteLine("Числа равны"); 
}
