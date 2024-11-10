namespace the_long_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello there what is your name");
            string user = Console.ReadLine();

            string filepath = user + ".txt";

            // init the score
            int score = 0;

            
            //checks if file exist and updated the score to the score from last time
            if (File.Exists(filepath)) { 
                score = int.Parse(File.ReadAllText(filepath));
                Console.WriteLine("Hello "+user+" your previous score was "+score);
            
            }

            //key press tracker
            while (true) { 
                var keyPressed = Console.ReadKey(true);
                if (keyPressed.Key == ConsoleKey.Enter) {
                    break;
                }

                score++;
                Console.WriteLine("here is your score: "+score);
            }

            //save the score in a text file
            File.WriteAllText(filepath, score.ToString());

            Console.WriteLine("You have pressed enter and here is your score: "+score);


        }
    }
}
