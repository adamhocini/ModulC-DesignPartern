using System;

// Classe concrète représentant une liasse HTML
public class LiasseHtml : Liasse
{
    // Imprime les documents HTML
    public override void Imprime()
    {
        Console.WriteLine("Impression des documents HTML:");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }
}
