Console.Write("Enter your name: ");
string username = Console.ReadLine() ?? "";

if (username.ToLower() == "masha")
{
    Console.WriteLine("Hey, It's Masha!");
}
else
{
    Console.Write("Hello, ");
    Console.Write(username);
    Console.WriteLine(".");
}