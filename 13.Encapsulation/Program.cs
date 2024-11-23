using Encapsulation;
using System.Text.Json;

class Program
{
    static List<Room> rooms = new List<Room>();
    static List<User> users = new List<User>();
    static User currentUser = null;
    static string adminPassword = "Admin123!";

    static void Main()
    {
        LoadData();
        MainMenu();
    }

    static void MainMenu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();

            if (currentUser == null)
            {
                Console.WriteLine("Hotel Room Reservation System");
                Console.WriteLine("1. View Rooms");
                Console.WriteLine("2. Book a Room");
                Console.WriteLine("3. Cancel Booking");
                Console.WriteLine("4. Register");
                Console.WriteLine("5. Login");
                Console.WriteLine("6. Admin Login");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");
            }
            else
            {
                Console.WriteLine($"Welcome, {currentUser.Username}!");
                Console.WriteLine("1. View Rooms");
                Console.WriteLine("2. Book a Room");
                Console.WriteLine("3. Cancel Booking");
                Console.WriteLine("4. View Profile");
                Console.WriteLine("5. Logout");
                Console.WriteLine("6. Admin Login");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option: ");
            }

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewRooms();
                    break;

                case "2":
                    BookRoom();
                    break;

                case "3":
                    CancelBooking();
                    break;

                case "4":
                    if (currentUser == null)
                    {
                        Register();
                    }
                    else
                    {
                        ViewProfile();
                    }
                    break;

                case "5":
                    if (currentUser == null)
                    {
                        Login();
                    }
                    else
                    {
                        Logout();
                    }
                    break;

                case "6":
                    AdminLogin();
                    break;

                case "7":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewRooms()
    {
        Console.Clear();
        Console.WriteLine("Available Rooms:");

        var availableRooms = rooms.Where(r => r.IsAvailable).ToList();

        if (availableRooms.Count == 0)
        {
            Console.WriteLine("No rooms available.");
        }
        else
        {
            foreach (var room in availableRooms)
            {
                Console.WriteLine($"Room {room.RoomNumber} ({room.Type}) - Price: {room.PricePerNight} - Occupancy: {room.MaxOccupancy}");
            }
        }

        Console.WriteLine("Press Enter to go back...");
        Console.ReadLine();
    }

    static void BookRoom()
    {
        if (currentUser == null)
        {
            Console.WriteLine("You must be logged in to book a room.");
            Console.ReadLine();
            return;
        }

        Console.Clear();

        Console.Write("Enter room type (Deluxe, Suite, Single, Double, etc.): ");
        string roomType = Console.ReadLine();

        Console.Write("Enter number of nights: ");
        int nights = int.Parse(Console.ReadLine());

        var availableRooms = rooms.Where(r => r.IsAvailable && r.Type.Equals(roomType, StringComparison.OrdinalIgnoreCase)).ToList();

        if (availableRooms.Count == 0)
        {
            Console.WriteLine("No available rooms of that type.");
            Console.ReadLine();
            return;
        }

        Console.WriteLine("Available Rooms:");
        foreach (var room in availableRooms)
        {
            Console.WriteLine($"Room {room.RoomNumber} - Price per night: {room.PricePerNight}");
        }

        Console.Write("Select a room by number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        var roomToBook = availableRooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (roomToBook != null)
        {
            roomToBook.BookRoom(currentUser.Username);

            currentUser.AddBooking($"Room {roomToBook.RoomNumber} ({roomToBook.Type}) for {nights} nights");

            SaveData();

            Console.WriteLine($"Room {roomToBook.RoomNumber} booked successfully!");
        }
        else
        {
            Console.WriteLine("Room not found.");
        }

        Console.WriteLine("Press Enter to go back...");
        Console.ReadLine();
    }

    static void CancelBooking()
    {
        if (currentUser == null)
        {
            Console.WriteLine("You must be logged in to cancel a booking.");
            Console.ReadLine();
            return;
        }

        Console.Clear();

        Console.Write("Enter the room number you want to cancel: ");
        int roomNumber = int.Parse(Console.ReadLine());

        var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber && r.BookedBy == currentUser.Username);

        if (room != null)
        {
            room.SetAvailability(true);
            room.CancelBooking();

            currentUser.RemoveBooking($"Room {room.RoomNumber} ({room.Type})");

            SaveData();

            Console.WriteLine("Booking canceled successfully! Press Enter to continue...");
        }
        else
        {
            Console.WriteLine("Booking not found. Press Enter to continue...");
        }

        Console.ReadLine();
    }

    static void Register()
    {
        Console.Clear();

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (users.Any(u => u.Username == username))
        {
            Console.WriteLine("Username already taken.");
        }
        else
        {
            var newUser = new User(username, password);

            users.Add(newUser);

            SaveData();

            Console.WriteLine("Registration successful!");
        }

        Console.WriteLine("Press Enter to go back...");
        Console.ReadLine();
    }

    static void Login()
    {
        Console.Clear();

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        currentUser = users.FirstOrDefault(u => u.Username == username && u.Password == password);

        if (currentUser != null)
        {
            Console.WriteLine($"Welcome back, {currentUser.Username}!");
        }
        else
        {
            Console.WriteLine("Invalid credentials. Press Enter to try again...");
        }

        Console.ReadLine();
    }

    static void Logout()
    {
        currentUser = null;
        Console.WriteLine("Logged out successfully!");
        Console.ReadLine();
    }

    static void ViewProfile()
    {
        Console.Clear();
        Console.WriteLine("Your Profile:");
        Console.WriteLine($"Username: {currentUser.Username}");

        if (currentUser.BookingHistory.Count == 0)
        {
            Console.WriteLine("You have no bookings.");
        }
        else
        {
            Console.WriteLine("Your Bookings:");

            foreach (var booking in currentUser.BookingHistory)
            {
                Console.WriteLine(booking);
            }
        }

        Console.WriteLine("Press Enter to go back...");
        Console.ReadLine();
    }

    static void AdminLogin()
    {
        Console.Clear();

        Console.Write("Enter admin password: ");
        string adminPass = Console.ReadLine();

        if (adminPass == adminPassword)
        {
            AdminMenu();
        }
        else
        {
            Console.WriteLine("Invalid admin password.");
            Console.ReadLine();
        }
    }

    static void AdminMenu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Admin Menu:");
            Console.WriteLine("1. View All Bookings");
            Console.WriteLine("2. View Total Income");
            Console.WriteLine("3. Add/Remove Rooms");
            Console.WriteLine("4. Logout");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewAllBookings();
                    break;

                case "2":
                    ViewTotalIncome();
                    break;

                case "3":
                    ManageRooms();
                    break;

                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void ViewAllBookings()
    {
        Console.Clear();

        Console.WriteLine("All Bookings:");

        foreach (var room in rooms.Where(r => !r.IsAvailable))
        {
            Console.WriteLine($"Room {room.RoomNumber} ({room.Type}) booked by {room.BookedBy}");
        }

        Console.WriteLine("Press Enter to go back...");
        Console.ReadLine();
    }

    static void ViewTotalIncome()
    {
        Console.Clear();

        decimal totalIncome = rooms.Where(r => !r.IsAvailable).Sum(r => r.PricePerNight);

        Console.WriteLine($"Total Income: {totalIncome:C}");

        Console.WriteLine("Press Enter to go back...");
        Console.ReadLine();
    }

    static void ManageRooms()
    {
        Console.Clear();
        Console.WriteLine("1. Add Room");
        Console.WriteLine("2. Remove Room");
        Console.WriteLine("3. Modify Room");
        Console.Write("Select an option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                AddRoom();
                break;

            case "2":
                RemoveRoom();
                break;

            case "3":
                ModifyRoom();
                break;

            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }

    static void AddRoom()
    {
        Console.Clear();

        Console.Write("Enter room number: ");
        int roomNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter room type (Deluxe, Suite, Single, Double): ");
        string roomType = Console.ReadLine();

        Console.Write("Enter price per night: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.Write("Enter cancellation fee: ");
        decimal cancellationFee = decimal.Parse(Console.ReadLine());

        Console.Write("Enter max occupancy: ");
        int maxOccupancy = int.Parse(Console.ReadLine());

        rooms.Add(new Room(roomNumber, roomType, price, cancellationFee, maxOccupancy));

        SaveData();

        Console.WriteLine("Room added successfully.");
        Console.ReadLine();
    }

    static void RemoveRoom()
    {
        Console.Clear();

        Console.Write("Enter room number to remove: ");
        int roomNumber = int.Parse(Console.ReadLine());

        var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (room != null)
        {
            rooms.Remove(room);

            SaveData();

            Console.WriteLine("Room removed successfully.");
        }
        else
        {
            Console.WriteLine("Room not found.");
        }

        Console.ReadLine();
    }

    static void ModifyRoom()
    {
        Console.Clear();

        Console.Write("Enter room number to modify: ");
        int roomNumber = int.Parse(Console.ReadLine());

        var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);

        if (room != null)
        {
            Console.Write("Enter new price per night: ");
            room.ChangePricePerNight(decimal.Parse(Console.ReadLine()));

            Console.Write("Enter new cancellation fee: ");
            room.ChangeCancelationFee(decimal.Parse(Console.ReadLine()));

            Console.Write("Enter new maximum occupancy: ");
            room.ChangeMaxOccupants(int.Parse(Console.ReadLine()));

            SaveData();

            Console.WriteLine("Room modified successfully.");
        }
        else
        {
            Console.WriteLine("Room not found.");
        }

        Console.ReadLine();
    }

    static void SaveData()
    {
        try
        {
            File.WriteAllText("rooms.json", JsonSerializer.Serialize(rooms));
            File.WriteAllText("users.json", JsonSerializer.Serialize(users));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving data: " + ex.Message);
        }
    }

    static void LoadData()
    {
        try
        {
            if (File.Exists("rooms.json"))
            {
                rooms = JsonSerializer.Deserialize<List<Room>>(File.ReadAllText("rooms.json")) ?? new List<Room>();
            }

            if (File.Exists("users.json"))
            {
                users = JsonSerializer.Deserialize<List<User>>(File.ReadAllText("users.json")) ?? new List<User>();

            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading data: " + ex.Message);
        }
    }
}