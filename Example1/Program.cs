Console.WriteLine ("Введите первое число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0 ;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a ;
}
Console.Write ("Max = ");
Console.WriteLine (max);
Console.Write ("Min = ");
Console.WriteLine (min);  
