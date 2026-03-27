using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
      List<Video> videos = new List<Video>();
        
        Video video1 = new Video("How to create a Youtube account", "Norah", 300);
        video1.AddComment(new Comment("John", "great work"));
        video1.AddComment(new Comment("Isaac", "thank you"));
        video1.AddComment(new Comment("Emily", "very helpful"));
        videos.Add(video1);

        Video video2 = new Video("How to make a cake", "Cate", 600);
        video2.AddComment(new Comment("Sarah", "looks delicious"));
        video2.AddComment(new Comment("Michael", "can't wait to try this"));
        video2.AddComment(new Comment("Kevin", "wow"));
        videos.Add(video2);

        Video video3 = new Video("How to play a guitar", "Modrick", 900);
        video3.AddComment(new Comment("David", "amazing tutorial"));
        video3.AddComment(new Comment("Jessica", "thank for sharing"));
        video3.AddComment(new Comment("Daniel", "this is awesome"));
        videos.Add(video3);
        

    foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"- {comment._author}: {comment._text}");
            }
            Console.WriteLine();
        }
    }
}