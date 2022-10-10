Console.Clear(); //Очищаем терминал
//int numA = Convert.ToInt32(Console.ReadLine());//Если хочешь включи, то пользователь сам будет задовать длинну масси
string[] matrix = new string[5];
int X = 3;
int Y = 0;
for (int i = 0; i < 5; i++)
{
 Console.WriteLine($"Введите данные: ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length <= X)
    {
        matrix[Y] = element;
        Y++;
    }
}
for (int i = 0; i < 5; i++)
    {
        Console.Write($"{matrix[i]} ");// выводим элемент массива
    }
//Console.WriteLine();
//PrintArray(matrix);

