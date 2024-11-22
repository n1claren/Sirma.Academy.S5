string inputFile = "C:\\Users\\n1c\\Desktop\\input.txt";
string outputFile = "C:\\Users\\n1c\\Desktop\\output.txt";

string[] wordsToSwap = Console.ReadLine().Split(" -> ");

string oldPart = wordsToSwap[0];
string newPart = wordsToSwap[1];

File.WriteAllText(inputFile, Console.ReadLine());

string text = File.ReadAllText(inputFile);

string updatedText = text.Replace(oldPart, newPart);

File.WriteAllText(outputFile, updatedText);