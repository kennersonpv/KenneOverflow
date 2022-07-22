using System;

namespace KenneOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var title = "How to create a class?";
            var description = "I'm a student and I don't know how to create a class.Can someone help me?";
            var post = new Post(title, description);
            Console.WriteLine(post.Title);
            Console.WriteLine(post.Description);
            Console.WriteLine(post.Creation);
            Console.WriteLine(post.VoteUp());
            Console.WriteLine(post.VoteUp());
            Console.WriteLine(post.VoteUp());
            Console.WriteLine(post.VoteDown());
            Console.WriteLine(post.VoteDown());
            Console.WriteLine(post.VoteDown());
            Console.WriteLine(post.VoteDown());
            Console.WriteLine(post.VoteDown());
        }
    }
}
