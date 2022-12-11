/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */


bool isParsedX = int.TryParse(Console.ReadLine(), out int X);
if (!isParsedX)
{
    Console.WriteLine("Данные ввели некорректно");
}

int result = CountNumKeyboard(X);
Console.WriteLine(result);


int CountNumKeyboard(int X)
{
    int count = 0;
    for (int i = X - 1; i >= 0; i--)
    {
        int N = int.Parse(Console.ReadLine());
        if (N > 0)
        {
            count++;
        }
    }
    return count;
}



