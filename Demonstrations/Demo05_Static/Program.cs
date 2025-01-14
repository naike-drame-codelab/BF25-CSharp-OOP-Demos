Chat c1 = new Chat()
{
    Nom = "Felix",
    Couleur = "Noir"
};
Chat c2 = new Chat()
{
    Nom = "Steve",
    Couleur = "Roux"
};

Chat.Race = "Siamois";
c1.SePresenter();
c2.SePresenter();

Chat.Race = "de goutière";
c1.SePresenter();
c2.SePresenter();

// extension de Chat dans une class static
c1.Manger();
c2.Manger();

// First() = méthode d'extension dans LINQ
int[] t = [1, 2, 5];
List<int> l = [1, 2, 3];
int value = l.First(i => i > 2);
int value2 = t.First(i => i > 2);

// pcq on override le ToString() propre à chaque méthode, on verra le nom du chat
Console.WriteLine(c1.ToString());

// librairie Dapper pour ajouter des méthodes d'extension à SqlConnection : Query()


// si j déclare un classe comme static, alors tout est static à l'intérieur et la class ne peut plus être instanciée
// il faut quand même ajouter static aux méthodes dans ce cas-là
// Ex : static class Chat
// static : à l'initialisation du programme et placé dans la mémoire statique --> n'est pas libéré pdt toute la durée de vie du programme.
// plus il y en a, plus il mettra du temps à charger
class Chat
{
    // propre aux instances  ---> chaque instance a sa propre Couleur et son propre Nom
    public string Nom { get; set; }

    public string Couleur { get; set; }

    // commune à toutes les instances ---> toutes les instances de la class Chat vont avoir la même Race
    public static string Race { get; set; }

    public void SePresenter()
    {
        Console.WriteLine($"Je m'appelle {Nom}, je suis {Couleur} et ma race est {Race}.");
    }

    public override string ToString()
    {
        return Nom;
    }
}

// méthode d'extension de la class Chat : permet d'ajouter des méthodes à une class sans modifier la class de base
// nécessite la création d'une class static avec des méthodes static
// utilisation de this pour appliquer les modifs à une class spécifique
static class ChatExtensions
{
    public static void Manger(this Chat c)
    {
        Console.WriteLine($"{c.Nom} est en train de manger.");
    }
}