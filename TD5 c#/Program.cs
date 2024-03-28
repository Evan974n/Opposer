int Somme(int i, int j)
{
    return i + j;
}

Console.WriteLine("Saisir un entier");
int vale = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Saisir un 2eme entier");
int vale2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Resultat");
Console.WriteLine(Somme(vale, vale2));
