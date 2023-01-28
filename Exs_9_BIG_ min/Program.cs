Console.WriteLine("Введите 1 число: ");
int First = int.Parse(Console.ReadLine());

Console.WriteLine("Введите 2 число: ");
int Second = int.Parse(Console.ReadLine());

if(First > Second)
{
    Console.WriteLine("Максимально число: " + First);
    Console.WriteLine("Минимальное число: " + Second);
}
else
{
    Console.WriteLine("Максимально число: " + Second);
    Console.WriteLine("Минимальное число: " + First);
}