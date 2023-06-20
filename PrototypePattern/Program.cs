using PrototypePattern;

var originalUser = new User
{
    UserId = "john.doe",
    Password = "password123"
};

var clonedUser = (User)originalUser.Clone();

Console.WriteLine("Original User: " + originalUser.UserId + ", " + originalUser.Password);
Console.WriteLine("Cloned User: " + clonedUser.UserId + ", " + clonedUser.Password);

Console.ReadLine();