/* Gavin Webster, IMGE-201, Oct 13th*/
namespace grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string studentName = "Gavin W";
            int[] grades = [100, 92, 87, 200, -20, 52, 82, 75, 67, 88];
            int average = 0;

            Console.WriteLine("Welcome "+studentName);
            Console.WriteLine("Here are your grades");
            for (int i = 0;  i<=9;) {
                Console.WriteLine(grades[i]);
                if (90 <= grades[i] && grades[i] <= 100)
                {
                    Console.WriteLine("This grade is an A!");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! a perfect score");
                    }
                }
                else if (80 <= grades[i] && grades[i] <= 89)
                {
                    Console.WriteLine("This grade is a B");
                }
                else if (70 <= grades[i] && grades[i] <= 79)
                {
                    Console.WriteLine("This grade is a C");
                }
                else if (65 <= grades[i] && grades[i] <= 69)
                {
                    Console.WriteLine("This grade is a D");
                }
                else if (0 <= grades[i] && grades[i] <= 64) {
                    Console.WriteLine("This grade is a F");
                }
                else
                {
                    Console.WriteLine("This is out of the range of 0-100. How did you even get this grade?");
                }
                average += grades[i];
                i ++;
            }
            average = average / 10;
            Console.WriteLine("Your final grade average is "+average);
            Console.WriteLine("We have display all grade for "+studentName);

        }
    }
}
