Secretaire monique = new Secretaire()
{
    Nom = "Monique",
    Telephone = new SamsungGalaxy() // abstraction de code : en précisant dans la propriété Telephone de Secretaire ITelephone, on peut ajouter soit un SamsungGalaxy() soit un VieuxNokia()
};

monique.FaireUneCommande();

// tout ce qui est défini dans une interface va être "abstrait"
// on va y définir des méthodes qui sont pas implémentées
// par défaut, public et abstract
// une interface permet de faciliter le découplage --> on se concentre plus sur le comportement que sur la nature
// interface = rendre l'application modulable via des dépendances faibles
// !!! règles à respecter (même si possible depuis le .Net 8) : 
    // - pas de variables membres
    // - pas de public devant
// 
interface ITelephone
{
    // on peut avoir des const, mais en général on place les variables const dans une class static (cf. Math())
    const int value = 4;

    // on évite d'avoir des variables simples, mais on peut avoir des propriétés
    List<string> Contacts { get; }
    void Telephoner(string numero);
    void EnvoyerSMS();
    void ConsulterMails();
}

class SamsungGalaxy : ITelephone  // ALT + Enter --> Implémenter interface
{
    public List<string> Contacts => throw new NotImplementedException();

    public void ConsulterMails()
    {
        throw new NotImplementedException();
    }

    public void EnvoyerSMS()
    {
        throw new NotImplementedException();
    }

    // surcharge de méthode possible
    public void Telephoner(string numero)
    {
        Console.WriteLine("J'appelle depuis un Samsung Galaxy.");
    } 
    
    public void Telephoner(int numero)
    {
        Console.WriteLine("J'appelle depuis un Samsung Galaxy.");
    }
}

class VieuxNokia : ITelephone
{
    public List<string> Contacts => throw new NotImplementedException();

    public void ConsulterMails()
    {
        throw new NotImplementedException();
    }

    public void EnvoyerSMS()
    {
        throw new NotImplementedException();
    }

    public void Telephoner(string numero)
    {
        Console.WriteLine("J'appelle avec un vieux Nokia.");
    }
}

class Secretaire
{
    public string Nom { get; set; }
    public ITelephone Telephone { get; set; }  // pour que Secretaire Monique puisse fonctionner avec n'importe quel type de téléphone, on précise qu'elle a besoin d'un ITelephone

    public void FaireUneCommande()
    {
        Telephone.Telephoner("022222222");
    }

}