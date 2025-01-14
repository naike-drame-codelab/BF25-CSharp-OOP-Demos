Carre c = new Carre() { Longueur = 1.5 };
Cercle cercle = new Cercle() { Rayon = 2 };

// pas possible d'instancier une class abstract car celle-ci est un modèle qui est incomplet et qui oblige ses class enfants à implémenter les éléments manquants
// Forme f = new Forme(); 

Console.WriteLine(c.CalculerAire()); // 2.25
Console.WriteLine(cercle.CalculerAire()); // 12.56

// création d'une class abstraite qu'on ne peut plus directement instancier
abstract class Forme
{
    public string Color { get; set; }

    // CalculerAire() est une méthode abstraite
    // pas encore définie
    // il appartiendra aux class enfants qui en hériteront d'implémenter ET d'overrider cette méthode abstract CalculerAire()
    // sans cela, le code ne compilera pas
    public abstract double CalculerAire();

}

// création d'une class concrète
class Cercle : Forme
{
    public double Rayon { get; set; }

    public override double CalculerAire()
    {
        return Math.PI * Rayon * Rayon;
    }
}

// création d'une class concrète
class Carre : Forme
{
    public double Longueur { get; set; }

    public override double CalculerAire()
    {
        return Longueur * Longueur;
    }
}

class Rectangle : Forme
{
    public double Longueur { get; set; }
    public double Largeur { get; set; }

    public override double CalculerAire()
    {
        return Longueur * Largeur;
    }
}