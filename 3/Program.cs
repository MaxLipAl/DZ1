Console.Write ("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine ());
if (Number % 2 == 0)
{
    Console.Write ($"Число {Number} является четным");
}
else
{
    Console.Write ($"Число {Number} не является четным");
}
