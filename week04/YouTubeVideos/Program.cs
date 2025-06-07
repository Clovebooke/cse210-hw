using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("The Future of AI", "TechGuru", 420);
        video1.AddComment(new Comment("Alice", "Amazing content!"));
        video1.AddComment(new Comment("Bob", "Very insightful."));
        video1.AddComment(new Comment("Charlie", "AI is fascinating."));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Travel Destinations", "TravelWithMe", 300);
        video2.AddComment(new Comment("Dave", "I want to go to all of these!"));
        video2.AddComment(new Comment("Eve", "Great video as always!"));
        video2.AddComment(new Comment("Frank", "Adding this to my bucket list."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("C# Tutorial for Beginners", "CodeAcademy", 540);
        video3.AddComment(new Comment("Grace", "Helped me a lot, thanks!"));
        video3.AddComment(new Comment("Heidi", "Clear and concise."));
        video3.AddComment(new Comment("Ivan", "Finally understood interfaces!"));
        videos.Add(video3);

        // Display videos and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine(new string('-', 40));
        }
    }
}
