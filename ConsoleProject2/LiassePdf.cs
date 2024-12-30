using System;

// Classe concrète représentant une liasse PDF
public class LiassePdf : Liasse
{
    // Imprime les documents PDF
    public override void Imprime()
    {
        Console.WriteLine("Impression des documents PDF:");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }
}