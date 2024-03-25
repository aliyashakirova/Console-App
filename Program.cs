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
