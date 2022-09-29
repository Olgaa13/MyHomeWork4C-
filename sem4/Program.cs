// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
//  возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Ограничения:
// - Нельзя использовать класс Math
// - Должна быть отдельная функция Power, которая возвращает результат
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

void Task25()
{
    Console.Write("Введите первое число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ведите второе число: ");
    int degree = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(power(number, degree));
    int power(int Num, int deg)
    {
        int result = 1;
        for (int i = 0; i < deg; i++)
            result *= Num;
        return result;
    }
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Ограничения:
// - Должна быть отдельная функция, которая возвразает результат суммы цифр
// - Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода


void Task27()
{
    int Summ(int num)
    {
        int result = 0;
        for (; num > 0; num /= 10)
            result = result + num % 10;
        return result;
    }
    Console.Write("Введите число: ");
    int numberN = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Сумма цифр в числе: " + Summ(numberN));
}



// Задача 29: Напишите программу, которая задаёт
//  массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ограничения:
// - Должна быть отдельная функция, которая создаёт
//  массив и отдельная функция вывода
// - Внутри функций (кроме функции вывода) НЕЛЬЗЯ использовать
//  класс Console. Только в основном блоке кода или в функции вывода

void Task29()
{
    int[] fillArray()
    {
        Random mas = new Random();
        int[] array = new int[8];
        int len = array.Length;
        for (int i = 0; i < len; i++)
        {
            array[i] = mas.Next(-35, 35);
        }
        return array;
    }
    int[] Sorter(int[] arrayIn)
    {
        for (int i = 0; i < arrayIn.Length; i++)
            for (int j = i; j < arrayIn.Length; j++)
                if (arrayIn[j] < arrayIn[i])
                {
                    int temp = arrayIn[j];
                    arrayIn[j] = arrayIn[i];
                    arrayIn[i] = temp;
                }
        return arrayIn;
    }
    void printArray(int[] arr)
    {
        Console.Write("[ ");
        for (int i = 0; i < arr.Length; i++)
            if (i < arr.Length - 1)
                Console.Write(arr[i] + ", ");
            else
                Console.Write(arr[i]);
        Console.WriteLine(" ]");
    } 
    int[] fillArr = fillArray();
    printArray(fillArr);
    Console.WriteLine("После сортировки: ");
    printArray(Sorter(fillArr));
}



// Task25();
// Task27();
Task29();
