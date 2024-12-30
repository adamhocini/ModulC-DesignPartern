using System;

public class LiassePdf : Liasse
{
    public override void Imprime()
    {
        Console.WriteLine("Impression des documents PDF:");
        foreach (var doc in documents)
        {
            Console.WriteLine(doc);
        }
    }
}