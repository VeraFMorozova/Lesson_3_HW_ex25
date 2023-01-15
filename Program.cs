// SЗадача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int getUserData(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan; 
    Console.WriteLine(message);
    Console.ResetColor();
    int UserData = int.Parse(Console.ReadLine()!);
    return UserData;
}
int getMathPow(int numberA, int numberB)
{
    int MathPow = 1;
    for(int i = 1; i <= numberB; i++)
    {
        MathPow = MathPow*numberA;
    } 
    return MathPow;   
}

void showData(string messageStart, int data)
{
    Console.Write(messageStart);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.Write(data);
    Console.ResetColor();
}

int numberA = getUserData("Введите число А");
int numberB = getUserData("Введите число B (должно быть натуральным)");
int MathPow = getMathPow(numberA, numberB);
showData ($"Число {numberA} в степени {numberB} равно ", MathPow);