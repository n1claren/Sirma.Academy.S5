namespace Encapsulation
{
    internal class User
    {
        private string userId;
        private string username;
        private string password;
        private List<string> bookingHistory;

        public string UserId { get => userId; }
        public string Username { get => username; }
        public string Password
        {
            get => password;

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    password = value;
                }
            }
        }
        public List<string> BookingHistory { get => new List<string>(bookingHistory); }

        public User(string username, string password)
        {
            this.userId = Guid.NewGuid().ToString();
            this.username = username;
            this.Password = password;
            this.bookingHistory = new List<string>();
        }

        public void AddBooking(string bookingDetail)
        {
            bookingHistory.Add(bookingDetail);
        }

        public void RemoveBooking(string bookingDetail)
        {
            if (bookingHistory.Contains(bookingDetail))
            {
                bookingHistory.Remove(bookingDetail);
            }
            else
            {
                Console.WriteLine("Booking not found in history.");
            }
        }
    }
}
