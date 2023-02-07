for (int i = 1; i <= 10; i++)
{
    for(int j = 1;j<= 10; j++)
    {
        Console.WriteLine(j+" x "+i+" = "+(j*i));
    }
}

string number = Console.ReadLine();
int i1 = int.Parse(number);
for (int i = 1;i <= i1; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        if (i % 3 == 0)
        {
            Console.Write("fizz");
        }
        if (i % 5 == 0)
        {
            Console.Write("buzz");
        }
    }
    else
    {
        Console.Write(i);
    }
    Console.WriteLine();
}