using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("[ESTUDIA CONMIGO]4-HOUR STUDY WITH ME🌦️ / calm piano / A Rainy Day in Shinjuku, Tokyo", "Abao en Tokio", 14897);
        v1.AddComment(new Comment("CoffeeTime732", "This is a reminder to the person reading this. You shouldn't give up...because, you even looking up for studying music means you're determined. You can do this love"));
        v1.AddComment(new Comment("polloyon1577", "Studying 3 hours a day for 7 months got me an entry level job in TI. Don't give up. You can do this!"));
        v1.AddComment(new Comment("doris1006", "The scenery looks great, it makes me feel comfortable while studying and working. Wishing whoever reads this comment will be successful in their career and even their dreams?"));

        Video v2 = new Video("How to Cook Pasta", "Chef Joshua", 420);
        v2.AddComment(new Comment("Ana", "I loved the recipe"));
        v2.AddComment(new Comment("Omar", "It looks delicious"));
        v2.AddComment(new Comment("Mariana", "Great video"));

        Video v3 = new Video("Cutest Dog on Earth", "Tabi's Life", 60);
        v3.AddComment(new Comment("Nikol", "What a cute dog"));
        v3.AddComment(new Comment("Carlos", "It really is the cutest dog on earth"));
        v3.AddComment(new Comment("Oscar", "ohh cute"));

        List<Video> videos = new List<Video>() { v1, v2, v3 };

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.GetTitle()}");
            Console.WriteLine($"Author: {v.GetAuthor()}");
            Console.WriteLine($"Length: {v.GetLengthSeconds()} seconds");
            Console.WriteLine($"Comments ({v.GetCommentCount()}):");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"  - {c.GetName()}: {c.GetText()}");
            }

            Console.WriteLine("-------------------------------------");
        }
    }
}