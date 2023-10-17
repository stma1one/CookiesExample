namespace CookiesExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cookie cookie = new Cookie(Cookie.EASY, 20, "Vanilla", 250);
            ChocolateCookie chocolate = new ChocolateCookie(Cookie.HARD, 120, "Chocolate",450, 45);
            chocolate.SetDuration(100);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(cookie+"\n\n");
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine(chocolate);
            Console.ForegroundColor = ConsoleColor.Black;


        }
    }
}