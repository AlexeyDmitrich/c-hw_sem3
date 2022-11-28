
int InputInt (){
    Console.WriteLine ("Введите целое число от 1 до 4");
    bool isNum = int.TryParse(Console.ReadLine(), out int num);
    if (isNum) {
        return num;
    }
    else {
        Console.WriteLine("Вы ввели некорректное значение");
        return -1;
    }
}

 /*
 Решение в группах задач:
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

Console.WriteLine("Введите номер четверти");
int coord = InputInt();
Console.WriteLine(GetCoordinates(coord));

string GetCoordinates(int num)
{
    if (num == 1)
    {
        return ("x > 0 && y > 0");
    }

    else if (num == 2)
    {
        return ("x < 0 && y > 0");
    }

    else if (num == 3)
    {
        return ("x < 0 && y < 0");
    }

    else if (num == 4)
    {
        return ("x > 0 && y < 0");
    }

    return "Какой-то странный запрос";
}

