// fonctions exécutées selon l'ordre d'insertion

// initialisation
TypeDeFonction maVariable = DireBye;

// ajout d'une nouvelle fonction avec l'opérateur +=
maVariable += DireBonjour;

// appel de la fonction // addEventListener()
maVariable?.Invoke(); // 1) Bye ! 2) Hello !
maVariable?.Invoke(); // 1) Bye ! 2) Hello !

// suppression d'une fonction avec l'opérateur -=
maVariable -= DireBye; 
maVariable?.Invoke(); // Hello !

// pas de ?. = erreur car plus de méthode à invoquer => UTILISATION DU NULL SAFE OPERATOR ?.
maVariable -= DireBonjour;
maVariable?.Invoke();

List<int> list = [1,2,3,4,5,6,42,47,99];
List<int> r1 = Filter(list, EstPair);
List<int> r2 = Filter(list, nb => nb % 3 == 0);
// List<int> result = Filter(l, delegate (int nb) { return nb % 3 == 0; });

List<string> list2 = ["papa", "maman", "Khun", "piu"];
List<string> result = Filter<string>(list2, item => item.StartsWith("p"));

// équivalent du Where dans LINQ
List<int> r3= list.Where( nb => nb % 3 == 0).ToList();

Console.WriteLine(string.Join(",", r1));

//Filtre f1 = (nb) => nb % 3 == 0;
//Filtre f2 = EstPair;
//Filtre f3 = EstPlusQue5;

void DireBonjour()
{
    Console.WriteLine("Hello !");
}
void DireBye()
{
    Console.WriteLine("Bye !");
}

int Somme (int nb1, int nb2)
{
    return nb1 + nb2;
}

#region Replacés par notre Filter()
/* 
 List<int> FilterPairs(List<int> entree)
{
    List<int> sortie = new List<int>();
    foreach (int i in entree)
    {
        if (EstPair(i)) sortie.Add(i);
    }

    return sortie;
}
List<int> FilterPlusQue5(List<int> entree)
{
    List<int> sortie = new List<int>();
    foreach (int i in entree)
    {
        if (EstPlusQue5(i)) sortie.Add(i);
    }

    return sortie;
}
*/
#endregion


List<int> Filter(List<int> entree, Filtre f)
{
    List<int> sortie = new List<int>();
    foreach (int i in entree)
    {
        if (f.Invoke(i)) sortie.Add(i);
    }

    return sortie;
}

// méthodes qui sont passées aux delegates correspondants
bool EstPair(int nb)
{
    return nb % 2 == 0;
}
bool EstPlusQue5(int nb)
{
    return nb > 5;
}


// création d'un type delegate
// on ne peut enregistrer à l'intérieur d'un delegate que des fonctions void sans paramètres
delegate void TypeDeFonction();

delegate bool Filtre(int nb);
