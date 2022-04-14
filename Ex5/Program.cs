int a=0;

while (a<99||a>1000)
{
Console.WriteLine("Введите трехзначное число");
a = Convert.ToInt32(Console.ReadLine());
}


Console.WriteLine(a%100%10);

