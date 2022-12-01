// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
// Задание должно быть выполнено в методе и метод должен вернуть массив чисел.

int num = InputInt();
int[] squaresTable = GetTableOfSqures(num);
PrintArray(squaresTable);

// метод для корректного ввода числа
int InputInt()
{
    Console.WriteLine("Введите целое положительное число");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum) {
        if (num >= 0){
        return num;
        } else {
            return num*(-1);
        }
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return 0; 
    }
}

// метод для получения таблицы кубов чисел от 1 до num, и формирования из неё массива
int[] GetTableOfSqures(int num)
{
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++) {
        arr[i] = (int)(Math.Pow(i+1, 3));
    }
return arr;
}

// метод для вывода массива в консоль
void PrintArray (int[] arr){
    for (int i = 0; i< arr.Length; i++) {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

