string input1File = "C:\\Users\\n1c\\Desktop\\input1.txt";
string input2File = "C:\\Users\\n1c\\Desktop\\input2.txt";
string outputFile = "C:\\Users\\n1c\\Desktop\\output.txt";

string[] fileOneLines = File.ReadAllLines(input1File);
string[] fileTwoLines = File.ReadAllLines(input2File);

StreamWriter outputWriter = new StreamWriter(outputFile);

using (outputWriter)
{
    for (int i = 0; i < fileOneLines.Length; i++)
    {
        outputWriter.WriteLine(fileOneLines[i]);
        outputWriter.WriteLine(fileTwoLines[i]);
    }
}