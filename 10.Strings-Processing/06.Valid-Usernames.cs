string[] usernames = Console.ReadLine().Split(", ");

foreach (var username in usernames)
{
    if (IsValidUsername(username))
    {
        Console.WriteLine(username);
    }
}

static bool IsValidUsername(string username)
{
    if (username.Length < 3 || username.Length > 16)
    {
        return false;
    }

    foreach (char ch in username)
    {
        if (!(char.IsLetterOrDigit(ch) || ch == '-' || ch == '_'))
        {
            return false;
        }
    }
    
    return true;
}