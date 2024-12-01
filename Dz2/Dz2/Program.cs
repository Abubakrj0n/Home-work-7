// See https://aka.ms/new-console-template for more information


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

while (a >= b)
{
    a -= b;
}
Console.WriteLine(a);
