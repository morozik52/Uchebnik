Console.WriteLine( "Вводим первое число");
int n1 = int.Parse(Console.ReadLine());
Console.WriteLine( "Вводим второе число");
int n2 = int.Parse(Console.ReadLine());
Console.WriteLine( "Вводим третье число");
int n3 = int.Parse(Console.ReadLine());
if(n1 > n2)
{
    if(n1 > n3 )
        return n1;
    else 
        return n3;
}
else
{
    if(n2 > n3)
        return n2;
    else
        return n3;
}


