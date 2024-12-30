// Constructeur concret pour les liasses PDF
public class ConstructeurLiasseVéhiculePdf : IConstructeurLiasseVéhicule
{
    private LiassePdf _liasse = new LiassePdf();

    // Construit un bon de commande PDF pour un client
    public void ConstruitBonDeCommande(string nomClient)
    {
        _liasse.AjouteDocument($"Bon de commande PDF pour {nomClient}");
    }

    // Construit une demande d'immatriculation PDF pour un client
    public void ConstruitDemandeImmatriculation(string nomClient)
    {
        _liasse.AjouteDocument($"Demande d'immatriculation PDF pour {nomClient}");
    }

    // Retourne la liasse PDF construite
    public Liasse ObtenirLiasse()
    {
        return _liasse;
    }
}