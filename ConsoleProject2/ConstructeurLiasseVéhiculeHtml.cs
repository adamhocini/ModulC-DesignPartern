// Constructeur concret pour les liasses HTML
public class ConstructeurLiasseVéhiculeHtml : IConstructeurLiasseVéhicule
{
    private LiasseHtml _liasse = new LiasseHtml();

    // Construit un bon de commande HTML pour un client
    public void ConstruitBonDeCommande(string nomClient)
    {
        _liasse.AjouteDocument($"Bon de commande HTML pour {nomClient}");
    }

    // Construit une demande d'immatriculation HTML pour un client
    public void ConstruitDemandeImmatriculation(string nomClient)
    {
        _liasse.AjouteDocument($"Demande d'immatriculation HTML pour {nomClient}");
    }

    // Retourne la liasse HTML construite
    public Liasse ObtenirLiasse()
    {
        return _liasse;
    }
}