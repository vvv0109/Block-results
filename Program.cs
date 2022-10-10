Console.Clear(); //Очищаем терминал
//int numA = Convert.ToInt32(Console.ReadLine());//Если хочешь включи, то пользователь сам будет задовать длинну масси
string[] matrix = new string[5];
int X = 3, Y = 0;
for (int i = 0; i < 5; i++)
{
 Console.WriteLine($"Введите данные: ");
 string numA = Convert.ToString(Console.ReadLine());
 if (numA.Length <= X)
    {
        matrix[Y] = numA;
        Y++;
    }
}
Console.Write ("Итог: ");
for (int i = 0; i < 5; i++)
    {
        Console.Write($"{matrix[i]} ");// выводим элемент массива
    }


