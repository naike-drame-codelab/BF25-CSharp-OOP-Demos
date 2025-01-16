// capturer une exception

// selon les applications, on va gérer les exceptions différemment
// il incombe au --programme-- de savoir comment gérer l'exception, pas à la fonction
// ce n'est pas que l'envoi de messages en cw, on peut envoyer un mail, un sms, créer un popup, faire un login, plusieurs éléments à la fois pour notifier de l'erreur capturée

// rmq : le C# autorise la division par zéro pour les doubles (affiche symbole de l'infini) - double.PositiveInfinity, double.NegativeInfinity
try
{
	int nb = int.Parse(Console.ReadLine());
    Console.WriteLine(Diviser(42, nb));
}
// capture erreur de format
catch (FormatException)
{
    Console.WriteLine("La valeur n'est pas un entier valide.");
}
// capture erreur null
catch (ArgumentNullException)
{
    Console.WriteLine("La valeur ne peut pas être nulle.");
}
// capture d'une exception personnalisée
catch (DivideByZeroException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}
// capture tout autre exception
catch (Exception)
{
    Console.WriteLine("Erreur inconnue.");
}
// que mon code ait échoué ou non, le programme va exécuter le bloc finally
// https://learn.microsoft.com/fr-fr/dotnet/standard/exceptions/how-to-use-finally-blocks
finally
{
    Console.WriteLine("Au revoir !!!");
}


double Diviser(double n1, double n2)
{
    if (n2 == 0)
    {
        // lancer une exception
        throw new DivideByZeroException();
    }
    return n1 / n2;
}

// création d'une exception personnalisée, qui hérite de Exception
class DivideByZeroException : Exception
{
    public DivideByZeroException() : base("Division par zéro impossible.") { }
}