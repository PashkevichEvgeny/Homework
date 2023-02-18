// Задача 50:
// Напишите программу, которая на вход принимает позиции элемента в пользовательском двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// array[1,7] -> такого числа в массиве нет

using static System.Console;

// Метод запрашивающий размер двумерного массива у пользователя 
void RowColumn(string text, out int row, out int column)
{
    // Сообщение для пользователя, какие данные необходимо ввести
    Write(text);
    // Запись размера двумерного массива
    string[] arrayString = ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    // Повторная запись размера в случаи ошибки
    while (arrayString.Length != 2)
    {
        Write($"Внимательнее! {text}");
        arrayString = ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
    }
    // Возврат количества столбцов и строк в массиве
    row = int.Parse(arrayString[0]);
    column = int.Parse(arrayString[1]);
}

// Метод создающий массив и заполняющий его значениями полученными от пользователя
int[,] UserArray()
{
    // Получение размера массива от пользователя
    RowColumn("\nВведите количество столбцов и строк через пробел: ", out int row, out int column);
    // Создание пустого массива
    int[,] array = new int[row, column];
    // Заполнение массива пользователем
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Write($"Введите число для элемента {j + 1} в строке {i + 1}: ");
            array[i, j] = int.Parse(ReadLine()!);
        }
    }
    // Возврат заполненного массива
    return array;
}

// Проверка существования позиции в массиве, которую спрашивает пользователь 
bool CheckingElement(int[,] array, out int checkRow, out int checkColumn)
{
    // Запрос у пользователя искомой позиции
    RowColumn("Введите номер элемента и номер строки через пробел: ", out int row, out int column);
    checkRow = row;
    checkColumn = column;
    // Если позиция меньше или больше возвращаем ложь
    if (row < 0
     || row > array.GetLength(0)
     || column < 0
     || column > array.GetLength(1))
    {
        return false;
    }
    // Если такая позиция есть, возвращаем правду и искомую позицию 
    return true;
}

// Вызов метода, который создает и заполняет массив
int[,] newArray = UserArray();

// Вывод значения искомой позиции, если правда
if (CheckingElement(newArray, out int checkRow, out int checkColumn))
{
    // Вывод элемента, если он есть. Отсчет столбцов и строк идет от 1
    Write($"\nЗначение элемента [{checkRow}, {checkColumn}] - {newArray[checkRow - 1, checkColumn - 1]}");
}
else
{
    // Если ложь, сообщаем, что такого числа нет
    Write($"\nтакого числа в массиве нет");
}