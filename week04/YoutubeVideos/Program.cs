using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create first video and add comments

        Video video1 = new Video("Learning C#", "Deborah", 300);
        video1.AddComment(new Comment("Felix", "Great tutorial!"));
        video1.AddComment(new Comment("Helen", "Very helpful, thanks!"));
        video1.AddComment(new Comment("Kieran", "I learned a lot."));
        videos.Add(video1);

        // Create second video and add comments

        Video video2 = new Video("Cooking Jollof Rice", "Olivia", 450);
        video2.AddComment(new Comment("Kaylan", "Looks delicious!"));
        video2.AddComment(new Comment("Florence", "Can't wait to try this recipe."));
        video2.AddComment(new Comment("Ariana", "Best recipe so far."));
        videos.Add(video2);

        // Create third video and add comments

        Video video3 = new Video("C# Design Patterns", "Shantel", 600);
        video3.AddComment(new Comment("Owen", "Design patterns are so useful."));
        video3.AddComment(new Comment("Adrian", "Thanks for the clear examples."));
        video3.AddComment(new Comment("Aliana", "Looking forward to more videos like this."));
        videos.Add(video3);

        // Display all videos and their comments
        foreach (var video in videos)
        {
            video.Display();
        }
    }
}