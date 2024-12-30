// Constructeur concret pour les liasses PDF
public class ConstructeurLiasseVéhiculePdf : IConstructeurLiasseVéhicule
{
    private LiassePdf _liasse = new LiassePdf();

    public void ConstruitBonDeCommande(string nomClient)
    {
        _liasse.AjouteDocument($"Bon de commande PDF pour {nomClient}");
    }

    public void ConstruitDemandeImmatriculation(string nomClient)
    {
        _liasse.AjouteDocument($"Demande d'immatriculation PDF pour {nomClient}");
    }

    public Liasse ObtenirLiasse()
    {
        return _liasse;
    }
}