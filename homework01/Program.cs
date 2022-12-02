
//получение числа с консоли
/*int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

int GetSumm(int number)
{
    int summ = 0;
    for (int i = 1; i <= number; i++)
    {
        summ += i;
    }

    return summ;
}

int number = GetNumber("Введите число");
int summ = GetSumm(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {summ}");
*/

//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)

//2, 4 -> 16

/*Console.Clear();
System.Console.WriteLine();

int number = 2;
int exponent = 10;
int count = 1;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

System.Console.WriteLine($"{number} ^ {exponent} = {result}");
System.Console.WriteLine();*/

/*int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}*/


/*int A = Convert.ToInt32("Введите число A: ");
int B = Convert.ToInt32("Введите число B: ");;
GetNumber(A, B);

void GetNumber(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
    return; 
}
int a = Console.WriteLine(A, B);
int result  (message)
{
    Console.WriteLine(string message);
    return Convert.ToInt32(Console.ReadLine());
}*/

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

//452 -> 11

//82 -> 10

//9012 -> 12

/*int num, sum = 0, r;
        Console.WriteLine("Enter a Number : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            r = num % 10;
            num = num / 10;
            sum = sum + r;
        }
        Console.WriteLine("Sum of Digits of the Number : "+sum);
        Console.ReadLine();*/


/*int num, sum = 0, a;
        Console.WriteLine("Введите число : ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            a = num % 10;
            num = num / 10;
            sum = sum + a;
        }
        Console.WriteLine("Сумма цифр числа:  "+sum);
        Console.ReadLine();*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]
//int Number = 8;
//Console.WriteLine("Будет создан массив длиной A ");
            //Console.Write("Введите любое число (A): ");
             //Number = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)

            {
                array[i] = new Random().Next(/*Number+1*/1,100);
                Console.Write(array[i] + "; ");
            }
            
            Console.WriteLine();

            //Вариант вывода вне цикла:
            Console.WriteLine($"[{String.Join("; ", array)}]");

        //break;

        //default:
            //begin = false;
            //break;
          
    
/*int[] array = new int[8];
Random random = new Random();
for (int i = 0; i < array.Length - 1; i++)
{
    array[i] = random.Next(0, 2);
    Console.Write(array[i] + " ");
}*/
 
/*int N = 8;

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(SetArray(N));*/