using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();
        List<Video> videos = new List<Video>();

        //video1
        Video video1 = new Video("Drifting but Not Lost: Amanda Sorensen's Story", "The Church of Jesus Christ of Latter-day Saints", 375);
        //comments
        Comment comment1 = new Comment("@cRADstig", "This video is so cool! My two biggest interests combined! Church and Motorsports!!");
        Comment comment2 = new Comment("@jalohabrown", "Thank you for sharing your faith and talents with us!");
        Comment comment3 = new Comment("@pkonneker", "Thanks for sharing, Sister.");
        //adding comments to the video
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);


        //video2
        Video video2 = new Video("Luke 1 | An Angel Foretells Christ's Birth to Mary | The Bible", "The Church of Jesus Christ of Latter-day Saints", 247);
        //comments
        Comment comment4 = new Comment("@mjbestfanmichaelcycle7800", "I love my heavenly father and the many blessings he has given me.");
        Comment comment5 = new Comment("@alyssawestra652", "Learning of Christ truly does bring us closer to him! ❤");
        Comment comment6 = new Comment("@KP-ej7gc", "I feel like I'm listening to Shakespeare. The Bible was so beautifully written.");
        //adding comments to the video
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);


        //video3
        Video video3 = new Video("Meet the Apostles: Elder Ulisses Soares", "Called to Share", 258);
        //comments
        Comment comment7 = new Comment("@careychristenson5041", "We love the Lords anointed. We pray for you and your family often.");
        Comment comment8 = new Comment("@7ajhubbell", "Thank you for sharing this with us!");
        Comment comment9 = new Comment("@raulofthehouses174", "Faith and perseverance");
        //adding comments to the video
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);


        //video4
        Video video4 = new Video("Gethsemane | October 2024 General Conference", "General Conference of The Church of Jesus Christ", 194);
        //comments
        Comment comment10 = new Comment("@MwendaMusa-pu2pq", "I will live this comment here so that whenever someone likes it, I come back to watch this video");
        Comment comment11 = new Comment("@viviennelewis4521", "We need a children's choir for EVERY Conference!");
        Comment comment12 = new Comment("@bo-whenyouknowyouknow", "I was in the choir!!! Drove 1hr each Sunday to get to rehearsal, exhausting, but so rewarding because we got to sing with THE TABERNACLE CHOIR for a music video!!!");
        //adding comments to the video
        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);

        //adding videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        //display the videos
        int i = 0;
        foreach (Video newVideo in videos)
        {
            Console.WriteLine($"VIDEO {i+=1}");
            newVideo.DisplayVideoInfo();
        }
    }
}