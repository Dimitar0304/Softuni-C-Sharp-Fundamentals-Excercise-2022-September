using System;

namespace _5._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            //first line we recive title of article between <h1> and </h1>
            // second line we recive content of article  between <article> and </article>
            // on next n lines while input !=end of comments we recive comments about article between <div> and </div>
            string titleOfArticle = Console.ReadLine();
            Console.WriteLine("<h1>");
            Console.WriteLine($"    {titleOfArticle}");
            Console.WriteLine("</h1>");
            string contentOfArticle = Console.ReadLine();
            Console.WriteLine("<article>");
            Console.WriteLine($"    {contentOfArticle}");
            Console.WriteLine("</article>");
            string comments = Console.ReadLine();
            while (comments!= "end of comments")
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {comments}");
                Console.WriteLine("</div>");


                comments = Console.ReadLine();
            }
        }
    }
}
