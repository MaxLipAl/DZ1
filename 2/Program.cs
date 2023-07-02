
Console.Write ("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine ());
Console.Write ("Введите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine ());
int max_number = Number1;
if (Number2 > max_number) max_number = Number2;
if (Number3 > max_number) max_number = Number3;
Console.Write ($"Максимальное число {max_number}");