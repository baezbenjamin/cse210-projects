using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("The Arch", "Jhon", 594);
        Comment comment1 = new Comment("SS59", "Good one");
        Comment comment2 = new Comment("FF48", "Great day");
        Comment comment3 = new Comment("GG37", "Liked this");

        video1.StoreComment(comment1);
        video1.StoreComment(comment2);
        video1.StoreComment(comment3);

        Video video2 = new Video("A Digital", "James", 683);
        Comment comment4 = new Comment("SQ78", "Thank you");
        Comment comment5 = new Comment("FE46", "Watched this");
        Comment comment6 = new Comment("GT35", "Share it");

        video2.StoreComment(comment4);
        video2.StoreComment(comment5);
        video2.StoreComment(comment6);

        Video video3 = new Video("An Experience", "Peter", 772);
        Comment comment7 = new Comment("AD13", "Looks good");
        Comment comment8 = new Comment("BC24", "Seems nice");
        Comment comment9 = new Comment("CA31", "Really good");
        Comment comment10 = new Comment("DB42", "Great one");

        video3.StoreComment(comment7);
        video3.StoreComment(comment8);
        video3.StoreComment(comment9);
        video3.StoreComment(comment10);

        Video video4 = new Video("The Concept", "Luke", 801);
        Comment comment11 = new Comment("EF98", "My favorite");
        Comment comment12 = new Comment("GH76", "Thanks friend");
        Comment comment13 = new Comment("IJ54", "Show me");
        Comment comment14 = new Comment("KL32", "Watch that");

        video4.StoreComment(comment11);
        video4.StoreComment(comment12);
        video4.StoreComment(comment13);
        video4.StoreComment(comment14);

        List<Video> videos = new List<Video>();
        videos = [];
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.GetDisplayText();
            Console.WriteLine("");
        }
    }
}