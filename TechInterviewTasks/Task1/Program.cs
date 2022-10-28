using System.Text.RegularExpressions;

string text = "The “C# Professional” course includes the topics I discuss in my CLR via C# book and \r\n" +
    " teaches how the CLR works thereby showing you how to develop applications NET and reusable components for the .NET Framework.\r\n";

Regex regex = new Regex(Regex.Escape(".")+"?\\w+#?");
MatchCollection matches = regex.Matches(text);
var matchesByLength = matches.DistinctBy(b => b.Value).GroupBy(m => m.Length).OrderBy(k => k.Key).ToList();

for(int i = 0; i < matchesByLength.Count; i++)
{
    Console.WriteLine("Words of length: {0}, Count:{1}", matchesByLength[i].Key, matchesByLength[i].Count());
    foreach( Match match in matchesByLength[i])
    {
        Console.WriteLine(match.Value);
    }
    Console.WriteLine();
}
Console.ReadKey();

