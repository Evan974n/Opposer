
using System;
int Oppose(int x)
{
    return -x;
}

int x = -7; 
int oppose = Oppose(x);
Console.WriteLine($"oppose de {x} est : {oppose}");
