using System;
using System.Collections.Generic;
using System.Text;

namespace IntermediateRefresher.Exercises
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public int NumberOfVotes { get; private set; }

        public void UpVote()
        {
            NumberOfVotes += 1;
        }

        public void DownVote()
        {
            NumberOfVotes -= 1;
        }


        public static void Run()
        {
            var post = new Post()
            {
                Title = "C# 2020",
                Description = "Learning C# @ 2020",
                CreatedAt = DateTime.Now,
            };

            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();

            Console.WriteLine($"Title: {post.Title}. Number of votes: {post.NumberOfVotes}");

        }

    }
}
