/* Итоговая проверочная работа.
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello","2","world",":-)"] -> ["2",":-)"]
["1234", "1567", "-2", "computer science"]->["-2"]
["Russia", "Denmark", "Kazan"]-> []
*/

Console.Clear();

int num = GetNumberFromUser("Сколько элементов будет в массиве? Укажите число: ", "Ошибка ввода! Нужно любое натуральное число");

string[] arrayFirst = new string[num];

FillFirstArray(arrayFirst);
PrintArray(arrayFirst);

int length = CheckLengthArray(arrayFirst);
string[] arraySecond = new string[length];

FillSecondArray(arrayFirst, arraySecond);
Console.Write(" -> ");
PrintArray(arraySecond);

//Вычисление длины массива
int CheckLengthArray(string[] inArray)
{
    int length = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3) length++;
    }
    return length;
}

//Заполнение второго массива
void FillSecondArray(string[] inArray1, string[] inArray2)
{
    int count = 0;
    for (int i = 0; i < inArray1.Length; i++)
    {
        if (inArray1[i].Length <= 3)
        {
            inArray2[count] = inArray1[i];
            count++;
        }
    }
}

//Запрос пользователю на ввод числа
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userInput) && userInput > 0;
        if (isCorrect)
            return userInput;
        Console.WriteLine(errorMessage);
    }
}

// Заполнение первого массива через ввод в консоль
void FillFirstArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"Введите {i + 1}-ый элемент массива: ");
        inArray[i] = Console.ReadLine() ?? "";
    }
}

//Вывод на печать массива
void PrintArray(string[] inArray)
{
    if (inArray.Length == 0) Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for (int i = 0; i < inArray.Length - 1; i++)
        {
            Console.Write($"\"{inArray[i]}\", ");
        }
        Console.Write($"\"{inArray[inArray.Length - 1]}\"]");
    }
}