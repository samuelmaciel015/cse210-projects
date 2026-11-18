using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment("Gdz-h2t", "From Timor Leste");
        Comment comment2 = new Comment("ksweiss", "Light the world every chance you get!");
        Comment comment3 = new Comment("lisawaldron14", "this is awesome!!");

        Video video1 = new Video("Go Tell It on the Mountain (feat. Yahosh Bonner) | The Nativity Told Around the World", "The Church of Jesus Christ", 195);

        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        ////////////////////////////////////////

        Comment comment4 = new Comment("ItsMeKonnor", "What a song!");
        Comment comment5 = new Comment("Melanie-jm3yu", "By leaning to Christ during times of trial instead of just thinking about my trial.");
        Comment comment6 = new Comment("inf_in_a_blankie", "It's so powerful how more people join the singing because that's what it's like with The Gospel!<3");

        Video video2 = new Video("Fear Not(feat.Paige Anne) | Official Music Video | Christian Music", "Strive To Be", 204);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        ////////////////////////////////////////

        Comment comment7 = new Comment("claudiosantos-maratonista325", "A Banda precisa viajar o Brasil fazendo esse Show em todo o Brasil para os Jovens do Brasil inteiro !");
        Comment comment8 = new Comment("vidadetrader9750", "É maravilhoso ver tantos jovens juntos louvando ao senhor, enquanto infelizmente muitos milhares estão no mundo das drogas.");
        Comment comment9 = new Comment("viviangiovanaaraujo7569", "Eu realizei meu sonho de ir no show dos jovens da igreja foi maravilhoso nao sabia se acantava ou se chorava de emoção ❤❤❤❤❤");

        Video video3 = new Video("Jovens da Igreja de Jesus Cristo | Ao Vivo do Ginásio do Ibirapuera – São Paulo", "Jovens da Igreja de Jesus Cristo", 4663);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        video1.GetVideoInfo();
        video2.GetVideoInfo();
        video3.GetVideoInfo();
    }
}
