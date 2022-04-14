Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());

if (a==0) Console.WriteLine("Введите число отличное от нуля");
else
if (a%2==0) Console.WriteLine("Четное");
else Console.WriteLine("Нечетное");
