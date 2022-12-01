// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль. Не использовать String!
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// могу, конечно и этот участок кода завернуть в метод, но мне кажется, это будет перебор. 
// вся работа в методе IsPallindrom()
Console.WriteLine("Введите целое число");
bool isInt = int.TryParse(Console.ReadLine(), out int num);
if (!(isInt)) {
    Console.WriteLine("Вы ввели неподходящее число");
} else {
    if (IsPallindrom(num)){
        Console.WriteLine($"Число {num} является палиндромом");
    } else {
        Console.WriteLine($"Число {num} не является палиндромом");
    }
}


// расчет модуля числа для работы с отрицательными вводными
int Md (int num){
    if (num >= 0){
        return num;
    } else {
        return (num * (-1));
    }
}

// определение числа знаков в числе (для построения массива)
int SecNum (int num) {    // принимает целое число и число для поиска
    int range = 0;
    int tempToRange = Md(num);  // временный дубликат числа для определения разряда
    while (tempToRange != 0){
        tempToRange = tempToRange / 10;
    //  Console.WriteLine($"Уменьшенное число {search}");
        range++;
    //  Console.WriteLine($"Предполагаемый разряд {range}");
    }
    return range;
}

// заполнение массива цифрами из числа
int[] ArrayFilling (int[] array, int num){
    int[] arr = array;
    for (int i = array.Length-1; i >= 0; i--){
        arr[i] = num%10;
        num = num/10;
    //    Console.WriteLine($"{i} : {arr[i]}");
    }
    return arr;
}

// определение палиндромальности
bool IsPallindrom (int num){
    int[] array = new int [SecNum(num)];
    array = ArrayFilling(array, num);
    for (int i = 0; i < array.Length; i++){
    //    Console.WriteLine(array[i]);
        if (!(array[i]==(array[(array.Length-1)-i]))) return false;
    }
    return true;
}