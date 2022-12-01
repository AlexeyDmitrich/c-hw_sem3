// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве. Задание должно быть выполнено в методе. 
// В методе не должно быть вывода в консоль.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double[] aPoint = new double [3];
aPoint = InputCoord();
double[] bPoint = new double [3];
bPoint = InputCoord();
double distanceAB = Distance(aPoint, bPoint);
//Console.WriteLine(distanceAB);

// метод для корректного ввода координат точки
double[] InputCoord() {
    double[] coordinates = new double[3];
    //Console.WriteLine("Введите координату точки X");
    bool isNumX = double.TryParse(Console.ReadLine(), out double x);
    if (isNumX) {
        coordinates[0] = x;
    }
    else {
    //    Console.WriteLine("Вы ввели некорректное значение");
        return InputCoord();
    }
    
    //Console.WriteLine("Введите координату точки Y");
    bool isNumY = double.TryParse(Console.ReadLine(), out double y);
    if (isNumY) {
        coordinates[1] = y;
    }
    else {
    //    Console.WriteLine("Вы ввели некорректное значение");
        return InputCoord();
    }

    //Console.WriteLine("Введите координату точки Y");
    bool isNumZ = double.TryParse(Console.ReadLine(), out double z);
    if (isNumY) {
        coordinates[2] = z;
    }
    else {
    //    Console.WriteLine("Вы ввели некорректное значение");
        return InputCoord();
    }
    return coordinates;
}

// Метод определения расстояния
double Distance (double[] pointA, double[] pointB){
    double distance = Math.Sqrt(Math.Pow((pointA[0]-pointB[0]),2)+Math.Pow((pointA[1]-pointB[1]),2)+Math.Pow((pointA[2]-pointB[2]),2));
    return distance;
}