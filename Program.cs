using System.Security.Cryptography;

System.Console.WriteLine("IELTS score average FOR academic");

System.Console.Write("Listening score: ");
string listeningScoreInput = Console.ReadLine()!;

System.Console.Write("Reading score: ");
string readingScoreInput = Console.ReadLine()!;

System.Console.Write("Speaking score: ");
string speakingScoreInput = Console.ReadLine()!;

System.Console.Write("Writing score: ");

string writingScoreInput = Console.ReadLine()!;
decimal[] scores={
    Convert.ToDecimal(readingScoreInput),
    Convert.ToDecimal(listeningScoreInput),
    Convert.ToDecimal(writingScoreInput),
    Convert.ToDecimal(speakingScoreInput)
    };
decimal averageScore = scores.Average();
int scoreInteger = (int)averageScore;
decimal remainder = averageScore-scoreInteger;

decimal scoreRemainder = remainder switch 
{
    _ when remainder<0.25m=>0,
    _ when remainder<0.75m=>0.5m,
    _=>1,

};

averageScore=scoreInteger+scoreRemainder;

//Console.WriteLine($"Avreage score: {averageScore}");
string average = averageScore switch
{
    9 or 8.5m => "Expert",
    8 or 7.5m => "Very Good",
    7 or 6.5m => "Good",
    6 or 5.5m => "Competent",
    5 => "Modest",
    _ =>"Invalid"
};
Console.WriteLine($"Your overall : {averageScore}!  Your Category: {average}");

