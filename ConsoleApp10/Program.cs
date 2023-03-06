User user = new User("username","password");


Console.WriteLine("Please enter the username:");
string UserName = Console.ReadLine();
Console.WriteLine("Please enter the  password:");
string Password = Console.ReadLine();

if(user.UserName != null && user.Password != null)
{
    Console.WriteLine("Completed successfully");
}
else
{
    Console.WriteLine("Incorrect ");
}