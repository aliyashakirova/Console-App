﻿//// Homework

//Console.WriteLine("Enter username:");
//string username = Console.ReadLine();

//Console.WriteLine($"Hello {username}!");
//// test test
//// commiting to a new branch Tmp
//// commit to a Tmp2


//// Homework 3
//// Task 1

//Console.WriteLine("Enter value of the operand1:");
//double operand1 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter value of the operand2:");
//double operand2 = double.Parse(Console.ReadLine());

//Console.WriteLine("Enter an arithmetic operator:");
//string arithmOper = Console.ReadLine();

//switch (arithmOper)
//{
//    case "+":
//        Console.WriteLine($"operand1 + operand2 = {operand1 + operand2}");
//        break;
//    case "-":
//        Console.WriteLine($"operand1 - operand2 = {operand1 - operand2}");
//        break;
//    case "*":
//        Console.WriteLine($"operand1 * operand2 = {operand1 * operand2}");
//        break;
//    case "/":
//        if (operand2 != 0)
//        {
//            Console.WriteLine($"operand1 / operand2 = {operand1 / operand2}");
//        }
//        else
//        {
//            Console.WriteLine("Can't be devided by 0");
//        }
//        break;
//    default:
//        {
//            Console.WriteLine("Can't perform the calculation");
//            break;
//        }
//}


//////Task 2
/////
//Console.WriteLine("Enter a number:");
//double number = double.Parse(Console.ReadLine());

//if ((number >= 0)&&(number <= 100))
//    {
//    if ((number >= 0) &(number <= 14)) 
//        {
//        Console.WriteLine($"The number = {number} is within the range [0..14]");
//        }
//    if ((number >= 15) & (number <= 35))
//        {
//            Console.WriteLine($"The number = {number} is within the range [15..35]");
//        }
//    if ((number >= 36) & (number <= 49))
//        {
//            Console.WriteLine($"The number = {number} is within the range [36..50]");
//        }
//    if (number == 50)
//        {
//            Console.WriteLine($"The number = {number} is within the range [36..50], [50..100]");
//        }
//    if ((number >= 51) & (number <= 100))
//        {
//            Console.WriteLine($"The number = {number} is within the range [50..100]");
//        }
//}
//else
//    {
//    Console.WriteLine("The entered number is out of the range");
//    }

////Task 3
///

//using System.Text;
//Console.OutputEncoding = Encoding.Unicode;
//Console.InputEncoding = Encoding.Unicode;

//Console.WriteLine("Type some word in Russian:");
//string wordRu = Console.ReadLine();


//switch (wordRu)
//{
//    case "жарко":
//        Console.WriteLine("hot");
//        break;
//    case "тепло":
//        Console.WriteLine("warm");
//        break;
//    case "холодно":
//        Console.WriteLine("cold");
//        break;
//    case "солнечно":
//        Console.WriteLine("sunny");
//        break;
//    case "облачно":
//    case "пасмурно":
//        Console.WriteLine("cloudy");
//        break;
//    case "дождливо":
//        Console.WriteLine("raining");
//        break;
//    case "снежно":
//        Console.WriteLine("snowing");
//        break;
//    case "ветренно":
//        Console.WriteLine("windy");
//        break;
//    case "туман":
//        Console.WriteLine("fog");
//        break;
//    default:
//        Console.WriteLine("Ooops... There is no translation for this word.");
//        break;
//}


//Task 4
//Console.WriteLine("Type some number:");
//int number = int.Parse(Console.ReadLine());

//if (number % 2 == 0)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}

////Task 4.1 - aöternative way
//Console.WriteLine("Type some number:");
//int number = int.Parse(Console.ReadLine());

//if ((number / 2) * 2 == number)
//{
//    Console.WriteLine("Even");
//}
//else
//{
//    Console.WriteLine("Odd");
//}
//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}
//for (int i = 0; i < 100; i += 10)
//{
//    Console.WriteLine(i);
//    if (i == 50) // gets out of the loop when i=50
//    {
//        break;
//    }
//    if (i == 20)
//    {
//        continue; // breaks the loop if i=20, but continues the loop, i.e. skips just 1 iteration
//    }
//}
//for (int i = 0; i < 100; i += 2) // only even numbers
//{
//    Console.WriteLine(i);
//}

//int number = 0;
//while (number < 10)
//{
//    Console.WriteLine(number);
//    number++;
//}

//var str = Console.ReadLine();

//while (str != "5")
//    { 
//    Console.WriteLine("enternumber");
//    str = Console.ReadLine();
//    }

//string str;
//do
//    {
//        Console.WriteLine("enternumber");
//        str = Console.ReadLine();
//    }
//while (str != "5");
//int[] array = [1, 14, 15];
////var array1 = new int[] {2,0,5,10};
//Console.WriteLine(array[2]);
//int[] array = [1, 14, 15];
//for (int i = 0; i < array.Length; i++)
//    {
//        Console.WriteLine(array[i]);
//    }

//int[] array = new int[5] { 1,2,3,546,123};
//int[] array2 = new int[10];

//1) [1, 2, 32113, -324, 0, 4] - найти все четные элементы массива и вывести их на экран

//int[] array = [1, 2, 32113, -324, 0, 4];

//for (int i = 0; i<array.Length; i++)
//{
//    if (array[i] % 2 == 0)
//    {
//        Console.WriteLine(array[i]);
//    }
//}

//int[,] array = new int[3, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write($"({i}, {j})");
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j]);
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}
//вывод массива на консоль
//Console.WriteLine("Введите длину массива:");
//int lenght = int.Parse(Console.ReadLine());
//int[] array = new int[lenght];

//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine($"[i] {i}");
//    array[i] = int.Parse(Console.ReadLine());
//}

//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($"{array[i]} ");
//}
////вывод двумерного массива на консоль
//Console.WriteLine("Введите кол-во строк массива");
//int lengthN = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите кол-во столбцов массива");
//int lengthM = int.Parse(Console.ReadLine());
//int[,] array = new int[lengthN, lengthM];

//for (int i = 0; i < lengthN; i++)
//{
//    for (int j = 0; j < lengthM; j++)
//    {
//        Console.WriteLine($"[i,j] {i},{j}");
//        array[i, j] = int.Parse(Console.ReadLine());
//    }
//}

// Random.Shared.Next(1, 3);

//for (int i = 0; i < lengthN; i++)
//{
//    for (int j = 0; j < lengthM; j++)
//    {
//        Console.Write($"{array[i, j]} ");

//    }
//    Console.WriteLine();
//}

//// Homework 4
//// Task 1
//int[] array = new int[] {1,50,654,9,13,4,58,54654,-9,6,0,45};
//
//Console.WriteLine("Enter a number:");
//int a = int.Parse(Console.ReadLine());
//int b = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] == a)
//    {
//        Console.WriteLine($"The number is found in the array, the element N is {i+1}");
//        b++;
//    }
//}
//if (b == 0)
//{
//        Console.WriteLine($"The number is NOT found in the array");
//}
//// Task 2
//int[] array = new int[] { 1, 50, 654, 9, 1, 13, 4, 58, 2, 54654, -9, 2, 6, 0, 45, 2, 1 };
//Console.WriteLine("Enter a number:");
//int a = int.Parse(Console.ReadLine());

//int count = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] == a)
//    { count++; }
//}

//int[] array2 = new int[array.Length - count];
//int j = 0;
//if (count != 0)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] != a)
//        {
//            array2[j] = array[i];
//            Console.WriteLine(array2[j]);
//            j++;
//        }
//    }
//}
//else
//{
//    Console.WriteLine("no such number");
//}

////Task 3
//Console.WriteLine("Enter length of an array:");
//int arrayLength = int.Parse(Console.ReadLine());
//int[] array = new int[arrayLength];

//Random rnd = new Random();
//for (int i = 0; i < arrayLength; i++)
//{
//    array[i] = rnd.Next();
//    Console.WriteLine(array[i]);
//}

//Console.WriteLine($"Max element = {array.Max<int>()}");
//Console.WriteLine($"Min element = {array.Min<int>()}");
//Console.WriteLine($"Avg = {array.Average()}");

////Task 4
//int[] array1 = new int[] { 1, 2, 3, 4, 5};
//int[] array2 = new int[] { 1, 2, 3, 4, -10};

//Console.Write("array1 = ");
//for (int i = 0; i < array1.Length; i++)
//{
//    Console.Write($"{array1[i]} ");
//}
//Console.WriteLine();
//Console.Write("array2 = ");
//for (int j = 0; j < array2.Length; j++)
//{
//    Console.Write($"{array2[j]} ");
//}
//Console.WriteLine();
//double avgArr1 = array1.Average();
//Console.WriteLine($"Avg1 = {avgArr1}");

//double avgArr2 = array2.Average();
//Console.WriteLine($"Avg2 = {avgArr2}");

//if (avgArr1 > avgArr2)
//    Console.WriteLine("The average of array1 is greater than the average of array2");
//else if (avgArr1 < avgArr2)
//{
//    Console.WriteLine("The average of array2 is greater than the average of array1");
//}
//else
//{
//    Console.WriteLine("The average of array1 is equal to the average of array2");
//}
////Task 4

//Console.WriteLine("Enter a length of an array:");
//int n = int.Parse(Console.ReadLine());
//while ((n <= 5) || (n > 10))
//{
//    Console.WriteLine("Array is not created as it's length needs to be within the range (5,10]. Enter a length of an array:");
//    n = int.Parse(Console.ReadLine());
//}
//int[] array = new int[n];
//Random rnd = new Random();
//for (int i = 0; i < n; i++)
//{
//    array[i] = rnd.Next(10);
//    Console.WriteLine(array[i]);
//}
////int[] array = new int[] { 1, 3, 5, 7};
//int count = 0;
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0)
//    {
//        count++;
//    }
//}
//if (count == 0)
//{
//    Console.WriteLine("There are no even numbers in the array.");
//}
//else
//{
//    int[] array2 = new int[array.Length - count];
//    int j = 0;
//    Console.WriteLine("Array containing only even numbers: ");
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] % 2 == 0)
//        {
//            array2[j] = array[i];
//            Console.Write($"{array2[j]} ");
//            j++;
//        }
//    }
//}
////Task 5

//Console.WriteLine("Enter a length of an array:");
//int n = int.Parse(Console.ReadLine());
//int[] array = new int[n];
//Random rnd = new Random();
//Console.Write("Array = ");
//for (int i = 0; i < array.Length; i++)
//{
//    array[i] = rnd.Next(100);

//    Console.Write($"{array[i]} ");
//}
//Console.WriteLine();

//Console.Write("New Array = ");
//for (int i = 0;i < array.Length; i++)
//{
//    if (i % 2 != 0)
//    {
//        array[i] = 0;
//    }
//    Console.Write($"{array[i]} ");
//}
////Task 6

//string[] names = {"Sasha","Masha","Dasha", "Pasha", "Misha"};
//Array.Sort(names);
//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}
////Task 7
//int[] arr  = {5,4,3,5,8};
//int k;

//for  (int i = 0; i < arr.Length; i++)
//{
//    for (int j=i+1; j< arr.Length; j++)
//        {
//        if (arr[i] > arr[j])
//            {
//                k= arr[i];
//                arr[i] = arr[j];
//                arr[j] = k;
//            }
//        }
//    Console.WriteLine(arr[i]);
//}
////Task 8
//int[,] arr1 = {{1,0,0,0},{0,1,0,0},{0,0,0,0}};
//int[,] arr2 = { { 1,2,3}, { 1,1,1}, {0,0,0},{2,1,0} };
//int[,] arrMultip = new int[3,3];

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        int sum = 0;
//        for (int k = 0; k < 4; k++)
//        { 
//        arrMultip[i,j] = arr1[i, k] * arr2[k,j] + sum;
//        sum = arrMultip[i,j];
//        }
//        Console.Write($"{arrMultip[i, j]} ");
//    }
//    Console.WriteLine();
//}

////Task 9 
//int[,] arr1 = { { 1, 0, 0 }, { -7, 1, 6 }, { -4, 2, 5 } };
//int[,] arr2 = { { 1, 2, 3 }, { 1, 1, 1 }, { 2, -3, 1 } };
//int[,] arrSum = new int[3, 3];

//for (int i = 0; i < 3; i++)
//{
//    for (int j = 0; j < 3; j++)
//    {
//        arrSum[i, j] = arr1[i, j]+ arr2[i,j];
//        Console.Write($"{arrSum[i, j]} ");
//    }
//    Console.WriteLine();
//}

////Task 10
//int[,] array = { { 1, 0, 0 }, { -7, 1, 6 }, { -4, 2, 5 } };

//int[] diag = new int[3];
//for (int i = 0; i < diag.Length; i++)
//{
//    for (int j = 0;j< diag.Length; j++)
//    {
//        if (i == j)
//        {
//            diag[j] = array[i,j];
//            Console.WriteLine(diag[j]);
//        }
//    }
//}
//// Task 11
//int[,] array = { { 1, 0, 0 }, { -7, 1, 6 }, { -4, 2, 5 } };
//int k;
//int[] diag = new int[3];
//for (int i = 0; i < diag.Length; i++)
//{
//    for (int j = 0; j < diag.Length; j++)
//    {
//        for (int l = j + 1; l < diag.Length; l++)
//        {
//            if (array[i,j] > array[i,l])
//            {
//                k = array[i, j];
//                array[i, j] = array[i, l];
//                array[i, l] = k;
//            }
//        }
//        Console.Write(array[i, j]);
//    }
//    Console.WriteLine();
//}