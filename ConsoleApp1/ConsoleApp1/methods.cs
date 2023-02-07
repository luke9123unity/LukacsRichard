double a = Math.Pow(2, 6);

float b = Math.Abs(12.4f);
float c = Math.Sign(-10); //előjel függvény pozitív esetén +1, negatív esetén -1 értékkel tér vissza

float d= Math.Max(7, 4);
float e= Math.Min(7, 4);

double f = Math.Ceiling(45.05);
double g = Math.Floor(45.05);
double h = Math.Round(45.05);


//--------------------------------------------

float a1 = Abs(-12.3f);
float a2 = Pow(9, 4);
Console.WriteLine(a2);

MyMethod(10);
MyMethod(2);
MyMethod(6);

//--------------------------------------------

float Abs(float num)
{
    if (num < 0)
        return -num;
    else
        return num;
}

float Max(float num1, float num2)
{
    if (num1 < num2)
    {
        return num2;
    }
    else
    {
        return num1;
    }
}

float Min(float num1, float num2)
{
    if (num1 < num2)
    {
        return num1;
    }
    else
    {
        return num2;
    }
}

float Pow(float num1, float num2)
{
    float result = 1;
    if (num2 > 1)
    {
        
        for(int i=0; i < num2; i++)
        {
            result *= num1;
        }
        return result;
    }
    else
    {
        //gyökvonás?
        return result;
    }
    
}

float Sign(float num)
{
    if (num < 0)
        return -1;
    else
        return 1;
}

//method

void MyMethod(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine(i);
    }
}