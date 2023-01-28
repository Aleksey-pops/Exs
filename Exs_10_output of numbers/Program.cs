Console.Write("Введите число: ");
int numberA = int.Parse(Console.ReadLine ());
int alt_numberA = numberA * (-1);
int min = 0;
int max = 0;

if (numberA > alt_numberA)
{
    max = numberA;
    min = alt_numberA;
}
else
{
    max = alt_numberA;
    min = numberA;
}
int i = min;
while (i = max + 1);
{
    Console.WriteLine(i);
    i++;
}


//    Console.WriteLine(numberB);
//    numberB++;

//while(numberB < numberA);
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