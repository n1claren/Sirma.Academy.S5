string type = Console.ReadLine();

string objOne = Console.ReadLine();
string objTwo = Console.ReadLine();

getMax(type, objOne, objTwo);

static void getMax(string type, object objOne, object objTwo)
{
    if (type == "int")
    {
        int int1 = Convert.ToInt32(objOne);
        int int2 = Convert.ToInt32(objTwo);

        Console.WriteLine(int1 > int2 ? int1 : int2);
    }
    else if (type == "char")
    {
        char char1 = Convert.ToChar(objOne);
        char char2 = Convert.ToChar(objTwo);

        Console.WriteLine(char1 > char2 ? char1 : char2);
    }
    else if (type == "string")
    {
        string str1 = objOne.ToString();
        string str2 = objTwo.ToString();

        Console.WriteLine(String.Compare(str1, str2) > 0 ? str1 : str2);
    }
    else
    {
        Console.WriteLine("Unsupported type");
    }
}