using BuilderPattern;

var builder = new UserBuilder();
var user = builder.SetUserId("john.doe").SetPassword("password123").Build();

Console.WriteLine(user.UserId + ", " + user.Password);
Console.ReadLine();