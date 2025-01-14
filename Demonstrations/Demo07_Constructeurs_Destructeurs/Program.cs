Chat c = new();
Chat c2 = new("Garfield");

Console.WriteLine(c.Nom);  // Felix
Console.WriteLine(c2.Nom); // Garfield

// je libère les ressources utilisées : utilisation du using
// c3.Dispose();
using (Chat c3 = new Chat())
{
    Console.WriteLine(c.Nom);
}

#region Utilisation du _
//List<int> l = new List<int>() { 1, 2, 3, 4 };
//l = l.Select((item, _) =>             // ---> _ : "je n'utilise pas cette valeur"
//{
//    return item * item;
//}).ToList();

//Console.WriteLine(); 
#endregion

//---------------------------------

// le constructeur permet d'initialiser le fonctionnement de l'instance de la class
// lorsqu'une class hérite d'une autre class, le system appelle le constructeur de base / sans paramètres de la class parent
// en C#, on peut implémenter l'interface IDisposable qui va imposer à la class d'implémenter la méthode Dispose()
class Chat : Animal, IDisposable
{
    public string Nom { get; set; }

    #region Constructeurs 
    // par défaut, un constructeur vide

    // constructeur appelé du parent : public Animal()
    // :base()  ---> va chercher constructeur de base du parent
    //public Chat()
    //{
    //    Nom = "Felix";
    //}
    //public Chat(string nom = "Felix") : base(5)
    //{
    //}
    public Chat() : this("Felix")
    {
        //Nom = "Felix";
    }

    // si on utilise uniquement des paramètres, je suis obligé d'implémenter ceux-ci au moment de l'instanciation  
    // constructeur appelé du parent : public Animal(int age)
    public Chat(string nom) : base(5)
    {
        // this correspond à l'instance en cours
        // pas nécessaire en C#
        this.Nom = nom;
    }

    #endregion

    #region ~Destructeur de la class
    ~Chat()
    {
        // on ne sait jamais quand le destructeur est appelé

    }

    // Dispose() permet de libérer l'espace mémoire utilisé par mon instance 
    public void Dispose()
    {
        Console.WriteLine("Je libérerai les ressources que j'utilise ici");
        GC.SuppressFinalize(this); // je dis au Garbage Collector : n'exécute jamais ~Chat()
    }

    #endregion
}

class Animal
{
    public DateTime DateDeNaissance { get; set; }

    public Animal()
    {
        DateDeNaissance = DateTime.Now;
    }

    public Animal(int age)
    {
        DateDeNaissance = DateTime.Now.AddYears(-age);
    }
}