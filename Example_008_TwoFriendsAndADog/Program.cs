Console.Write("Enter first's friend speed: ");
int firstFriendSpeed = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter second's friend speed: ");
int secondFriendSpeed = int.Parse(Console.ReadLine() ?? "");
Console.Write("Enter dog's speed: ");
int dogSpeed = int.Parse(Console.ReadLine() ?? "");
Console.Write("What distance between two friends is? ");
double distance = double.Parse(Console.ReadLine() ?? "");
int count = 0;
int dogDirection = 2;
double time = 0;

while (distance > dogSpeed + firstFriendSpeed + secondFriendSpeed)
{
    if (dogDirection == 2)
    {
        time = distance / (dogSpeed + secondFriendSpeed);
        dogDirection = 1;
    }
    else
    {
        time = distance / (dogSpeed + firstFriendSpeed);
        dogDirection = 2;
    }
    count++;
    distance = distance - time * (firstFriendSpeed + secondFriendSpeed);
}

Console.Clear();
Console.Write("The dog can check friends " + count);

if (count == 1)
{
    Console.Write(" time ");
}
else
{
    Console.Write(" times ");
}

Console.WriteLine("before they will meet each other.");