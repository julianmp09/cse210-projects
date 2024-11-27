using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some videos
        Video video1 = new Video("Video 1", "Julian", 120);
        Video video2 = new Video("Video 2", "Daniel", 150);
        Video video3 = new Video("Video 3", "John", 180);

        // Create comments for each video
        Comment comment1 = new Comment("Daniela", "Great video!");
        Comment comment2 = new Comment("Nicole", "Loved the explanation.");
        Comment comment3 = new Comment("Karen", "Interesting content.");

        Comment comment4 = new Comment("William", "Very helpful, thanks.");
        Comment comment5 = new Comment("James", "Excellent quality.");
        Comment comment6 = new Comment("Michael", "I disagree with point 2.");

        Comment comment7 = new Comment("David", "Well explained.");
        Comment comment8 = new Comment("Edward", "Would like more practical examples.");
        Comment comment9 = new Comment("Emily", "Thanks for the video!");

        // Add comments to videos
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (var video in videos)
        {
            video.ShowInfo();
            Console.WriteLine();
        }
    }
}
