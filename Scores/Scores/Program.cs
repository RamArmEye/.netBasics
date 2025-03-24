// See https://aka.ms/new-console-template for more information
Console.WriteLine("Please enter your name");
string date = DateTime.Today.ToShortDateString();
string uname = Console.ReadLine();
string msg = $"\nWelcome back {uname}! Today is {date}.";
Console.WriteLine(msg);

string path = @"C:\Users\Ramusiup\Documents\myRepository\Scores\Scores\studentScores.txt";
string[] lines = System.IO.File.ReadAllLines(path);

double tScore = 0.0;

Console.Write("\nStudent Scores: \n");
foreach (string line in lines)
{
    Console.WriteLine("\n" + line);
    double score = Convert.ToDouble(line);
    tScore += score;
}
double avgScore = tScore / lines.Length;
Console.WriteLine("\nTotal of" + lines.Length + "student scores. tAverage score:" + avgScore);



Console.WriteLine("\n\nPress any key to exit.");
Console.ReadKey();


