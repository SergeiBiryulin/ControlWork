
/*  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → [] 
*/


class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите строки через запятую: ");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(',');

        string[] outputArray = new string[inputArray.Length];
        int count = 0;

        foreach (string str in inputArray)
        {
            if (str.Length <= 4)
            {
                outputArray[count] = str;
                count++;
            }
        }
        string[] trimmedArray = new string[count];
        Array.Copy(outputArray, trimmedArray, count);
        outputArray = trimmedArray;
        if (count == 0)
        {
            System.Console.WriteLine("Пустой массив: ");
        }
        else
        {
            System.Console.WriteLine("Результат: ");
            foreach (string str in outputArray)
            {
                System.Console.Write(str);
            }
        }
    }
}










