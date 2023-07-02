int i = 2;
Console.Write ("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine ());
while (i < Number)
{
    if (i % 2 == 0) Console.Write ($"{i} ");
    i++;
}
