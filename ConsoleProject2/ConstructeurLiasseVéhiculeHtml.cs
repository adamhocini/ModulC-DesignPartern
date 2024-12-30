// Constructeur concret pour les liasses HTML
public class ConstructeurLiasseVéhiculeHtml : IConstructeurLiasseVéhicule
{
    private LiasseHtml _liasse = new LiasseHtml();

    public void ConstruitBonDeCommande(string nomClient)
    {
        _liasse.AjouteDocument($"Bon de commande HTML pour {nomClient}");
    }

    public void ConstruitDemandeImmatriculation(string nomClient)
    {
        _liasse.AjouteDocument($"Demande d'immatriculation HTML pour {nomClient}");
    }

    public Liasse ObtenirLiasse()
    {
        return _liasse;
    }
}