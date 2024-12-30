// Classe représentant un vendeur qui utilise un constructeur de liasse
public class Vendeur
{
    private readonly IConstructeurLiasseVéhicule _constructeur;

    // Constructeur qui prend un constructeur de liasse en paramètre
    public Vendeur(IConstructeurLiasseVéhicule constructeur)
    {
        _constructeur = constructeur;
    }

    // Construit une liasse pour un client particulier
    public Liasse Construit(string nomClient)
    {
        _constructeur.ConstruitBonDeCommande(nomClient);
        _constructeur.ConstruitDemandeImmatriculation(nomClient);
        return _constructeur.ObtenirLiasse();
    }
}