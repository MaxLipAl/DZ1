
Console.Write ("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine ());
if (Number1 > Number2) 
{ 
    Console.WriteLine($"Большее число первое {Number1}, второе {Number2}");
}
else 
{
    Console.WriteLine($"Большее число второе {Number2}, первое {Number1}");
};