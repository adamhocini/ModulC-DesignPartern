using System.Collections.Generic;

// Classe abstraite représentant une liasse de documents
public abstract class Liasse
{
    protected IList<string> documents = new List<string>();

    // Ajoute un document à la liasse
    public void AjouteDocument(string document)
    {
        documents.Add(document);
    }

    // Méthode abstraite pour imprimer les documents
    public abstract void Imprime();
}