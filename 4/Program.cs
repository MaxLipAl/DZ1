int i = 2;
Console.Write ("Введите число: ");
int Number = int.Parse(Console.ReadLine ());
while (i < Number)

{
    if (i != Number - 1) {Console.Write($"{i}, ");}
    else {Console.Write (i);};
    i = i + 2;
}
    if (i % 2 == 0 && i == Number) Console.Write(i);
    
    
 

