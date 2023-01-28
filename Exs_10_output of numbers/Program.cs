Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine ());
int numberB = numberA * (-1);
while(numberB < numberA);
{
    Console.WriteLine(numberB);
    numberB++;
}

//{
//   Console.WriteLine("выводим числа: " + numberA);
//}
//int numberB = numberA * (-1);
//while(numberA <= numberB);
//
//{
//    Console.WriteLine(numberB);
//    numberB++;
//}