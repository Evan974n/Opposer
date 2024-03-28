
using System;
int Moy (int a, int b)
{
    return (a+b)/2;
}




Console.WriteLine("donnez a :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("donnez b :");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Resultat");
Console.WriteLine(Moy(a, b));
