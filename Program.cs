// Задача 19. Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

int Palindrome(int number)
{
    int n = number;
    int rev = 0;
    while (rev <= 9999)
    {
        int num = n % 10;
        rev = rev * 10 + num;
        n = n / 10;
    }
    return (rev);
}

void TestPalindrome(int i, int j)
{
    if (i == j)
    {
        Console.WriteLine("Да, это число является палиндромом");
    }
    else
    {
        Console.WriteLine("Нет, это число не является палиндромом");
    }
}

int GetNum()
{
    int number = 0;
    while (number < 9999 || number > 99999)
    {
        Console.WriteLine("Введите пятизначное число: ");
        number = int.Parse(Console.ReadLine() ?? "0");
    }
    return number;
}

int number = GetNum();
int reverse = Palindrome(number);
TestPalindrome(number, reverse);




