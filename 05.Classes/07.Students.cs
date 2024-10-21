using Classes;

string input = "";

List<Student> students = new List<Student>();

while ((input = Console.ReadLine()) != "end")
{
    List<string> temp = input.Split(" ").ToList();

    string firstName = temp[0];
    string lastName = temp[1];
    int age = int.Parse(temp[2]);
    string hometown = temp[3];

    Student currentStudent = new Student(firstName, lastName, age, hometown);

    students.Add(currentStudent);
}

string town = Console.ReadLine();

foreach (var student in students)
{
    if (student.Hometown == town)
    {
        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
    }
}