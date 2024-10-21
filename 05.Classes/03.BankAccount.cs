using Classes;

List<BankAccount> bankAccounts = new List<BankAccount>();

string command = "";

while ((command = Console.ReadLine()) != "end")
{
    string commandType = command.Split(' ')[0].ToLower();

    if (commandType == "create")
    {
        BankAccount tempBankAccount = new BankAccount();

        Console.WriteLine($"Account ID{tempBankAccount.GetID} created");

        bankAccounts.Add(tempBankAccount);
    }

    else if (commandType == "deposit")
    {
        double[] argss = command.Split(" ").Skip(1).Select(x => double.Parse(x)).ToArray();

        double id = argss[0];
        double amount = argss[1];

        BankAccount bankAccount = bankAccounts.FirstOrDefault(x => x.GetID == id);

        if (bankAccount == null)
        {
            Console.WriteLine("Account does not exist");
            continue;
        }

        bankAccount.Deposit(amount);

        Console.WriteLine($"Deposited {amount} to ID{id}");
    }

    else if (commandType == "setinterest")
    {
        double newInterest = double.Parse(command.Split(" ")[1]);

        BankAccount.SetInterestRate(newInterest);

        Console.WriteLine($"Global interest rate set to {newInterest}");
    }

    else if (commandType == "getinterest")
    {
        int id = int.Parse(command.Split(" ")[1]);
        int years = int.Parse(command.Split(" ")[2]);

        BankAccount tempBankAccount = bankAccounts.FirstOrDefault (x => x.GetID == id);

        if (tempBankAccount == null)
        {
            Console.WriteLine("Account does not exist");
            continue;
        }

        Console.WriteLine($"{tempBankAccount.GetInterest(years):F2}"); 
    }
}