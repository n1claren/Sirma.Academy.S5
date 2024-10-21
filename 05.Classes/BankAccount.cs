namespace Classes
{
    internal class BankAccount
    {
        private static int currentID = 0;
        private static double interestRate = 0.02;

        private int ID;
        private double balance;

        public BankAccount()
        {
            currentID++;
            ID = currentID;
            balance = 0;
        }

        public static void SetInterestRate(double interest)
        {
            interestRate = interest;
        }
        
        public double GetInterest(int years)
        {
            return interestRate * years * balance;
        }

        public void Deposit (double amount)
        {
            balance += amount;
        }

        public int GetID => ID;
    }
}
