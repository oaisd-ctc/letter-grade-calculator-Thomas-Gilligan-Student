using System;

class Program {

    public static void Main(string[] args) {
        Console.Clear();
        Console.WriteLine("Enter your number score:");
        float gradeNum = float.Parse(Console.ReadLine() ?? "0");
        getResult(gradeNum);

    }

    public static void getResult(float number) {

        switch (number) {
            case >= 100:
                Console.WriteLine("Wow! 100...That's impressive!\nLetter Grade: A+"); break;
            case >= 90:
                Console.WriteLine("Very nice!\nLetter Grade: A"); break;
            case >= 80:
                Console.WriteLine("Keep it up!\nLetter Grade: B"); break;
            case >= 70:
                Console.WriteLine("You got this, keep working!\nLetter Grade: C"); break;
            case >= 60:
                Console.WriteLine("Keep trying!\nLetter Grade: D"); break;
            default:
                Console.WriteLine("Don't give up!\nLetter Grade: E"); break;
                
        }
    }
}