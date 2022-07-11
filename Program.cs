//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

void Zadacha25()
{
    Console.WriteLine();
    Console.WriteLine("Введите число ");
    int numb1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень числа ");
    int numb2 = Convert.ToInt32(Console.ReadLine());
    int result = numb1;
    int i = 1;
  
while (i < numb2)
{
    result = result * numb1;
    i++; 
}
Console.WriteLine($"{numb1}^{numb2} = " + result); 
}


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12


void Zadacha27()
{
Console.WriteLine();
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int i = number;

while (i > 0)
{
    sum = sum + i % 10;
    i = i / 10;
}
Console.WriteLine($"Сумма цифр числа {number} = " + sum); 
}


//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и выводит отсортированный по модулю массив.
//-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
//6, 1, -33 -> [1, 6, -33]

Console.WriteLine();

void Zadacha29()

{
    int [] array = new int[8];
    Console.Write("Неотсортированный случайный массив: ");
    for (int index = 0; index < array.Length; index++)
    {
        array [index] = new Random().Next(-100, 100);
        Console.Write( array[index] + " ");
    }
    Console.WriteLine();
   
    for (int index = array.Length-1; index > 0; index--)
    {
            for (int min = 0; min < index; min++) 
        {
            if (Math.Abs(array[min]) > Math.Abs(array[min+1]))
            {
                int temp = array[min]; 
                array[min] = array[min+1];
                array[min+1] = temp;
            }
        }
    }
       
    Console.Write("Отсортированный массив по модулю : ");    
    //Console.Write( array[index] + " ");
    for ( int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
}
    
Zadacha29();
//Zadacha27();
//Zadacha25();
    






