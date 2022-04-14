int a =0;

while (a<=0)
{
Console.WriteLine("Введите число больше 0");
a = Convert.ToInt32(Console.ReadLine());
}

int count = 0;

while (count<=a)
{
    if (count%2==0) Console.WriteLine(count);
    count+=1;
}
