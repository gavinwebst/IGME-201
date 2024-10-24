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

        private void Reset() {
            this.name = "Not assigned";
            this.exp = 0;
        }

    }

    //creating a paladin
    public class Paladin : Character {
        public Paladin(string name) : base(name) { 
        
        }
    }


    //makes a weapon for the character
    public struct Weapon
    {
        //stats for the weapon
        public string name;
        public int damage;

        //weapon contructor with two variables
        public Weapon(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public void PrintWeaponStats() {
            Console.WriteLine($"Weapon: {this.name} - {this.damage} DMG");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {


            Character hero = new Character();
            //Console.WriteLine($"Hero: {hero.name} - {hero.exp} EXP");
            hero.PrintStatsInfo();

            Character heroine = new Character("Agatha");
            //Console.WriteLine($"Hero: {heroine.name} - {heroine.exp} EXP");
            heroine.PrintStatsInfo();

            //creating a weapon
            Weapon huntingbow = new Weapon("Hunting bow", 105);
            huntingbow.PrintWeaponStats();

            //testing reference types
            Character villian = hero;

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();

            villian.name = "Sir Kane the Brave";

            hero.PrintStatsInfo();
            villian.PrintStatsInfo();


            //testing value types
            //note: hunting bow is declared above
            Weapon warBow = huntingbow;

            huntingbow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            warBow.name = "War Bow";
            warBow.damage = 155;

            huntingbow.PrintWeaponStats();
            warBow.PrintWeaponStats();

            //working with encapsulation
            hero.Reset();

            //Experimenting with Inheritance
            Paladin knight = new Paladin("Sir Arthur");
            knight.PrintStatsInfo();
        }
    }
}
