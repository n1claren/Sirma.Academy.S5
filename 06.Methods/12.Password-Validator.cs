string password = Console.ReadLine();

ValidatePassword(password);

static int CountDigits(string password)
{
    int digitCount = 0;

    foreach (char ch in password)
    {
        if (char.IsDigit(ch))
        {
            digitCount++;
        }
    }

    return digitCount;
}

static bool IsOnlyLettersAndDigits(string password)
{
    foreach (char ch in password)
    {
        if (!char.IsLetterOrDigit(ch))
        {
            return false;
        }
    }

    return true;
}

static void ValidatePassword(string password)
{
    bool isValid = true;

    if (password.Length < 6 || password.Length > 10)
    {
        Console.WriteLine("Password must be between 6 and 10 characters.");
        isValid = false;
    }

    if (!IsOnlyLettersAndDigits(password))
    {
        Console.WriteLine("Password must contain only letters and digits.");
        isValid = false;
    }

    if (CountDigits(password) < 2)
    {
        Console.WriteLine("Password must have at least 2 digits.");
        isValid = false;
    }

    if (isValid)
    {
        Console.WriteLine("Password is valid");
    }
}