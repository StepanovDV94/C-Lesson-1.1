Console.WriteLine("Введите целое число");
int a = Convert.ToInt32(Console.ReadLine());

int count = a*(-1);

    while (count<=a)
    {
        if (count%2==0&&count!=0) Console.WriteLine(count);
        count+=1;
    }

