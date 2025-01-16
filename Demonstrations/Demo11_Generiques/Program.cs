// Génériques : 
// quand on ne sait pas encore avec quoi on va travailler, on va utiliser type T
// en fonction du type du paramètre, le système va déterminer le type à attribuer
// applicable sur des class ou des méthodes

List<string> l = ["papa", "maman", "toto", "pepette"];
List<string> result = l.Filter();

List<T> Filter<T>(List<T> entree, Filtre<T> f)
{
    List<T> sortie = new List<T>();
    foreach (T i in entree)
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

delegate bool Filtre<T>(T nb);
