namespace classes_structs_oop
{
    //creates the hero class
    public class Character {
        //variables about character
        public string name;
        public int exp = 0;

        //made a constructor
        public Character() {
            name = "not assigned";
        }

        //made a second contructor but with a variable
        public Character(string name) {
            this.name = name;
        }

        //tell the hero's stats
        public void PrintStatsInfo()
        {
            Console.WriteLine($"Hero {this.name} - {this.exp} EXP");
        }

    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Character hero = new Character();
            Console.WriteLine($"Hero: {hero.name} - {hero.exp} EXP");

            Character heroine = new Character("Agatha");
            Console.WriteLine($"Hero: {heroine.name} - {heroine.exp} EXP");
        }
    }
}
