namespace Encapsulation
{
    internal class Room
    {
        private int roomNumber;
        private string type;
        private decimal pricePerNight;
        private decimal cancellationFee;
        private int maxOccupancy;
        private bool isAvailable;
        private string bookedBy;

        public int RoomNumber
        {
            get => roomNumber;
            private set => roomNumber = value;
        }

        public string Type
        {
            get => type;
            private set => type = value;
        }

        public decimal PricePerNight
        {
            get => pricePerNight;
            private set => pricePerNight = value;
        }

        public decimal CancellationFee
        {
            get => cancellationFee;
            private set => cancellationFee = value;
        }

        public int MaxOccupancy
        {
            get => maxOccupancy;
            private set => maxOccupancy = value;
        }

        public bool IsAvailable
        {
            get => isAvailable;
            private set => isAvailable = value;
        }

        public string BookedBy
        {
            get => bookedBy;
            private set => bookedBy = value;
        }

        public Room(int roomNumber, string type, decimal pricePerNight, decimal cancellationFee, int maxOccupancy)
        {
            this.roomNumber = roomNumber;
            this.type = type;
            this.pricePerNight = pricePerNight;
            this.cancellationFee = cancellationFee;
            this.maxOccupancy = maxOccupancy;
            this.isAvailable = true;
            this.bookedBy = "";
        }

        public void BookRoom(string username)
        {
            IsAvailable = false;
            BookedBy = username;
        }

        public void SetAvailability(bool available)
        {
            IsAvailable = available;
        }

        public void CancelBooking()
        {
            BookedBy = "";
        }

        public void ChangePricePerNight(decimal newPrice)
        {
            PricePerNight = newPrice;
        }

        public void ChangeCancelationFee(decimal fee)
        {
            CancellationFee = fee;
        }

        public void ChangeMaxOccupants(int maxOccupants)
        {
            MaxOccupancy = maxOccupants;
        }
    }
}
