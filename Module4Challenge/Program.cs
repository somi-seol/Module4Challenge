using System.Reflection;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DAD JOKE GENERATOR\n");

            string[] jokesArray =
            {
                "“Bird flu”? Yeah, they tend to do that!",
                "“Roadwork ahead”? Yeah, i sure hope it does!",
                "“Chef's kiss”? Do they really?",
                "“Apartment complex”? I find it quite simple!",
                "“What's up stairs”? They can't talk!",
                "I haven't slept for 10 days, because that would be too long!",
                "When I was a kid my parents moved a lot, but I always found them!",
                "I saw a bank that said “24 HOUR BANKING” but I don't have that much time!",
                "I'll always remember my father's last words as he bled out in my arms: “Be positive!”",
                "People say nothing is impossible, but I do nothing every day!",
                "People say I'm indecisive, but I don't know about that...",
                "I saw a stationary store move once!"
            };
            Random rnd = new Random();
            
            string ask = ""; //might be null?
            do
            {
                int rndNum  = rnd.Next(0, 12);  // creates a number between 0 and 11

                Console.WriteLine($"\n{jokesArray[rndNum]}");

                
                Console.Write("\nWould you like to hear another joke? (y/n)\n> ");
                ask = Console.ReadLine().ToLower();
                
                while(ask != "y" && ask != "n" && ask!= null) // checks null just in case
                {
                    Console.Write("Invalid input. Please enter y or n\n> ");
                    ask = Console.ReadLine().ToLower();
                }
            }
            while (ask == "y");

            Console.WriteLine("\nThank you for listening to my dad jokes! :)");
        }
    }