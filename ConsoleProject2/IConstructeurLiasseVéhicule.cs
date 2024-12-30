// Interface pour les constructeurs de liasse de véhicule
public interface IConstructeurLiasseVéhicule
{
    void ConstruitBonDeCommande(string nomClient);
    void ConstruitDemandeImmatriculation(string nomClient);
    Liasse ObtenirLiasse();
}
