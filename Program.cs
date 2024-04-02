//// Homework

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
//        break;
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
//int[,] arr1 = { { 1, 0, 0, 0 }, { 0, 1, 0, 0 }, { 0, 0, 0, 0 } };
//int[,] arr2 = { { 1, 2, 3 }, { 1, 1, 1 }, { 0, 0, 0 }, { 2, 1, 0 } };
//int[,] arrMultip = new int[arr1.GetLength(0), arr2.GetLength(1)];

//for (int i = 0; i < arrMultip.GetLength(0); i++)
//{
//    for (int j = 0; j < arrMultip.GetLength(1); j++)
//    {
//        int sum = 0;
//        for (int k = 0; k < arr1.GetLength(0); k++)
//        {
//            arrMultip[i, j] = arr1[i, k] * arr2[k, j] + sum;
//            sum = arrMultip[i, j];
//        }
//        Console.Write($"{arrMultip[i, j]} ");
//    }
//    Console.WriteLine();
//}

////Task 9 
//int[,] arr1 = { { 1, 0, 0 }, { -7, 1, 6 }, { -4, 2, 5 } };
//int[,] arr2 = { { 1, 2, 3 }, { 1, 1, 1 }, { 2, -3, 1 } };
//int[,] arrSum = new int[arr1.GetLength(0), arr2.GetLength(1)];

//for (int i = 0; i < arrSum.GetLength(0); i++)
//{
//    for (int j = 0; j < arrSum.GetLength(1); j++)
//    {
//        arrSum[i, j] = arr1[i, j] + arr2[i, j];
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

// Lesson 5
//// Task 1
//using System.Text;

//string str = "12312dfgsfj234234hdfhjtestefdhfghfthvghftesthdffgh456456df  hygfd0000";

//string str2 = str.Replace("test", "testing");
//int l = str2.Length;
//char[] chr = str2.ToCharArray();
//StringBuilder str3 = new StringBuilder("");
//for (int i = 0; i < l; i++)
//{
//    if (!char.IsDigit(chr[i]))
//    {
//        str3 = str3.Append(chr[i]); 
//    }
//}
//Console.Write(str3);

////Task 2

//string str1 = "Welcome";
//string str2 = "to";
//string str3 = "the";
//string str4 = "TMS";
//string str5 = "lessons";

//string phraseFormat = "{0} {1} {2} {3} {4}.";

//Console.WriteLine(string.Format(phraseFormat,str1,str2,str3,str4,str5));

//Task 3
//string str = "teamwithsomeofexcersiceabcwanttomakeitbetter";

//string[] strarr = str.Split("abc");
//int l= strarr.Length;
//for (int i = 0; i < l; i++)
//{
//    Console.WriteLine(strarr[i]);
//}
////Task 4
//string str = "Bad day";
//string substr = "Good";

//str = str.Substring(3);
//str = str.Insert(0, substr);
//str = str.Insert(str.Length,"!!!!!");
//str = str.Remove(str.Length - 1);
//str = string.Concat(str, "?");
//Console.WriteLine(str);
////Task 5


/////
//string docNum = "5558-aBc-0386-LMq-1a2b";

//string[] strs = OnlyNumberParts(docNum);

//HideOnlyLetterParts(docNum);

//string docNumOnlyLetters = DocNumOnlyLettersLowerCase(strs);

//DocNumOnlyLettersUpperCase(docNumOnlyLetters);

//DocNumContainsSubstr(docNum, "abc");

//DocNumStartWith(docNum, "555");

//DocNumEndsWith(docNum, "1a2b");

//static void DocNumStartWith(string docNum, string substr)
//{
//    if (docNum.StartsWith(substr))
//        Console.WriteLine($"The document number starts with '{substr}'");
//    else Console.WriteLine($"The document number does not start with '{substr}'");
//}

//static void DocNumContainsSubstr(string docNum, string substr)
//{
//    if (docNum.Contains(substr, StringComparison.OrdinalIgnoreCase))
//        Console.WriteLine($"The document number contains the substring '{substr}'");
//    else
//        Console.WriteLine($"The document number does not contain the substring '{substr}'");
//}

//static string DocNumOnlyLettersLowerCase(string[] strs)
//{
//    int l = strs[4].Length;
//    char[] chr = strs[4].ToCharArray();
//    string str4 = "";
//    for (int i = 0; i < l; i++)
//    {
//        if (!char.IsDigit(chr[i]))
//        {
//            str4 = string.Concat(str4, chr[i]);

//        }
//        else
//        {
//            str4 = string.Concat(str4, '/');
//        }
//    }
//    string phraseFormat = "{0}/{1}{2}";
//    string docNumOnlyLetters = string.Format(phraseFormat, strs[1], strs[3], str4).ToLower();
//    Console.WriteLine(docNumOnlyLetters);
//    return docNumOnlyLetters;
//}

//static void DocNumOnlyLettersUpperCase(string docNumOnlyLetters)
//{
//    StringBuilder strBldr = new StringBuilder("Letters:");
//    strBldr.Append(docNumOnlyLetters.ToUpper());
//    Console.WriteLine(strBldr);
//}

//static void HideOnlyLetterParts(string docNum)
//{
//    string docNumA = docNum.Replace("jSg", "***");
//    docNumA = docNumA.Replace("LMq", "***");
//    Console.WriteLine(docNumA);
//}

//static string[] OnlyNumberParts(string docNum)
//{
//    string[] strs = docNum.Split("-");
//    Console.WriteLine(string.Concat(strs[0], strs[2]));
//    return strs;
//}

//static void DocNumEndsWith(string docNum, string substr)
//{
//    if (docNum.EndsWith(substr))
//        Console.WriteLine($"The document number ends with '{substr}'");
//    else Console.WriteLine($"The document number does not end with '{substr}'");
//}
