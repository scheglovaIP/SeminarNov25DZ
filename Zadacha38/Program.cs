//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


int size = ReadInt("Введите размер массива: ");
double[] numbers = new double[size];

FillArrayRandomDoubleNumbers(numbers, 1, 100);
WriteArray(numbers);

double min = numbers[0];
double max = numbers[0];

for(int i=0; i<numbers.Length; i++)
{
    if(numbers[i]<min) min=numbers[i];
    if(numbers[i]>max) max=numbers[i];
}

Console.WriteLine($"{max} - {min} = {Math.Round(max-min, 2)}");



//Используемые методы

void FillArrayRandomDoubleNumbers(double[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        Random sluchainoe_chislo = new Random();
        double floating_point = sluchainoe_chislo.NextDouble() + sluchainoe_chislo.Next(min, max);
        floating_point = Math.Round(floating_point, 2);
        array[i] = floating_point;
    }
}


void WriteArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
