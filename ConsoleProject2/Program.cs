using System;

class Programme
{
    static void Main(string[] args)
    {
        // Demande à l'utilisateur de choisir le type de document à créer
        Console.WriteLine("Choisissez le type de document à créer (1 pour HTML, 2 pour PDF):");
        string choix = Console.ReadLine();

        IConstructeurLiasseVéhicule constructeur;

        // Instancie le constructeur approprié en fonction du choix de l'utilisateur
        if (choix == "1")
        {
            constructeur = new ConstructeurLiasseVéhiculeHtml();
        }
        else
        {
            constructeur = new ConstructeurLiasseVéhiculePdf();
        }

        // Crée un vendeur avec le constructeur choisi
        Vendeur vendeur = new Vendeur(constructeur);

        // Construit la liasse pour un client particulier
        Liasse liasse = vendeur.Construit("nom client particulier");

        // Imprime la liasse
        liasse.Imprime();
    }
}
