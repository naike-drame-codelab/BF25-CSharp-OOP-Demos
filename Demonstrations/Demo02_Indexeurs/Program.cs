using Demo01_ClassProp.Models;

Car c = new Car();

// appel de l'indexeur pour récupérer un élément sur base de son index dans le tableau
c[0] = "Toto";
c[1] = "Tata";
c[2] = "Titi";

Console.WriteLine("----- Passagers : -----");
for (int i = 0; i <= 3; i++)
{
    if (c[i] != null)
    {
        Console.WriteLine($"Passager {i + 1} : {c[i]}");
    }
}