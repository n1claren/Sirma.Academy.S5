string inputFile = "C:\\Users\\n1cla\\Desktop\\input.txt";
string outputFile = "C:\\Users\\n1cla\\Desktop\\output.txt";

File.WriteAllText(outputFile, File.ReadAllText(inputFile));