string inputFile = "C:\\Users\\n1c\\Desktop\\input.txt";
string outputFile = "C:\\Users\\n1c\\Desktop\\output.txt";

StreamReader sr = new StreamReader(inputFile);
StreamWriter sw = new StreamWriter(outputFile);

List<string> reversedLines = new List<string>();

using (sr)
{
    string line = null;

    while ((line = sr.ReadLine()) != null)
    {
        char[] chars = line.ToCharArray();

        string reversedLine = String.Concat(chars.Reverse().ToArray());

        reversedLines.Add(reversedLine);
    }
}

using (sw)
{
    foreach (string line in reversedLines)
    {
        sw.WriteLine(line);
    }
}