using System.Data;
using System.Diagnostics;

Console.WriteLine("Введите число");

int a= Convert.ToInt32( Console.ReadLine());

if( a>0)
{
   int b= a + 5;
    Console.WriteLine(b);
}

else
{
    int b = a - 5;
    Console.WriteLine(b);
}
Console.ReadKey();

Console.WriteLine("Введите число 1");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int a2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int a3 = Convert.ToInt32(Console.ReadLine());

if (a1 < a2)
{
    a1 = a2;
    if (a1 >a3)
    {
        Console.WriteLine(a1);
    }
    else
    {
        Console.WriteLine(a3);
    }
}
Console.ReadKey();

Console.WriteLine("Введите число 1");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
int b3 = Convert.ToInt32(Console.ReadLine());

if (b1 > 0 & b2 >0 & b3>0 )
{
    Console.WriteLine(b1 + b2 +b3);

      
} 
if (b1 >0 & b2 >0 & b3<0)
    {
        Console.WriteLine(b1+b2);
    }
if (b2 > 0 & b3 > 0& b1<0)
    {
        Console.WriteLine(b2 + b3);
    }
else
    {
        Console.WriteLine(b1 +b3);
    }
Console.ReadKey();

Console.WriteLine("Введите число ");
int c = Convert.ToInt32(Console.ReadLine());
if (c > 10)
{
    Console.WriteLine(c * 2);
}
else
{
    Console.WriteLine("Введенно занчение меньше 10");
}
Console.ReadKey();

Console.WriteLine("Введите число 1-7");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1:
        Console.WriteLine("Понедельник");
        break;
    case 2:
        Console.WriteLine("Вторник");
        break;
    case 3:
        Console.WriteLine("Среда");
        break;
    case 4:
        Console.WriteLine("Четверг");
        break;
    case 5:
        Console.WriteLine("Пятница");
        break;
    case 6:
        Console.WriteLine("Суббота");
        break;
    case 7:
        Console.WriteLine("Воскресеье");
        break;

}
Console.ReadKey();


int k = 200;
while (k>199)
{
   int res= k % 17;
    if(res==0)
    {
        Console.WriteLine(k);
        break;
    }
    else
    {
        k++;
    }
}
Console.ReadKey();

double distant = 10;

double d = 1;

while (distant < 20)
{
    distant += distant * 0.05;

    d++;

}
Console.WriteLine(d);

Console.ReadKey();


while (distant < 100)
{
    distant = distant + distant * 0.05;

    d++;

}
Console.WriteLine(d);
Console.ReadKey();

int fac = Convert.ToInt32(Console.ReadLine());
int g = 1;
for (int i = 1; fac >= i; i++)
{
    g *= i;

}
Console.WriteLine(g);
Console.ReadKey();

int nubmer = Convert.ToInt32(Console.ReadLine());
for (int i = 2; nubmer >= i; i++)
{
    if (nubmer % i == 0)
    {
        Console.WriteLine(i);
        break;
    }
}
Console.ReadKey();
