using AdapterPattern;

LegacyUser legacyUser = new LegacyUser
{
    FirstName = "John",
    LastName = "Doe",
    UserName = "john.doe",
    Password = "password123",
    Email = "john.doe@example.com"
};

INewUser newUser = new LegacyUserAdapter(legacyUser);

string fullName = newUser.GetFullName(); // "John Doe"
string username = newUser.GetUsername(); // "john.doe"
string emailAddress = newUser.GetEmailAddress(); // "john.doe@example.com"

Console.WriteLine(fullName + ", " + username + ", " + emailAddress);
Console.ReadLine();