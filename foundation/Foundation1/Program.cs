using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> com1 = new List<Comment>
        {
            new Comment("Hared", "I really loved this video."),
            new Comment("Edwin", "I am a subscriber of this channel."),
            new Comment("Jake", "I want to meet you in person, and record some videos together.")
        };

        List<Comment> com2 = new List<Comment>
        {
            new Comment("Peter", "Hi , i made this for my school project. My family and friends loved it so much."),
            new Comment("Jenkinsoup", "Good video!"),
            new Comment("sharifulislam6387", "hey, i have a breadboard smaller than that can i make one?"),
            new Comment("Adriana", "I will be an influencer like you!")
        };

        List<Comment> com3 = new List<Comment>
        {
            new Comment("Suseela.VSuseela", "If i use only 10 led it will work or not need any changes in code please reply sir"),
            new Comment("k.smadhubhashana5152", "dude how to get the setch"),
            new Comment("Lucas", "Sir my LED are working but it is very very low voltage didn't see  at cleared in the code need to give little more voltage what can I do"),
            new Comment("David", "Thanks a lot!"),
            new Comment("Angela", "I learned a lot with your videos!")
        };


        Video video1 = new Video("I love to code", "The programmer", 1567, com1);
        Video video2 = new Video("The best adventure of my life", "Happy Mom", 8456, com2);
        Video video3 = new Video("This is my Family", "Tom Barber", 2391, com3);

        List<Video> videos = new List<Video> { video1, video2, video3 };



        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Duration: {video.GetDuration()}");
            Console.WriteLine($"Comments ammount: {video.GetCommentsCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()} - {comment.GetText()}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

        }





    }
}