using System;

namespace FactoryMethodApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var twitter = new TwitterMessanger("CODE BLOG", "password");
            var twit = twitter.CreateMessage("Hi, Brol", "CODE BLOG", "Soer");
            twit.Send();

            var instagram = new InsagramrMessanger("CODE BLOG", "password");
            var photo = instagram.CreateMessage("win.jpg", "CODE BLOG", "Winderto");
            photo.Send();

            Console.ReadLine();
        }
    }
}
