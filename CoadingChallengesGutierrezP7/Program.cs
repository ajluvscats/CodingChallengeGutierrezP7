using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
class CHalenges
{




    public static void Main(string[] args)
    {


        /*Welcome the user to my program
        Console.WriteLine("Weclome to my coding challenge program. I will be making a variety of functions for you to use. \n Please pick one.");

        Console.WriteLine("We are going to use the number adder today called sum. Please give me two numbers.");

        var number1 = Console.ReadLine();
        int numberToUse1 = int.Parse(number1);

        Console.WriteLine("Got it, Give me your second number. \n");

        var number2 = Console.ReadLine();
        int numberToUse2 = int.Parse(number2);

        Console.WriteLine("The Sum of the number: " + number1 + " and the number: " + number2 + "is equal to " + Sum(numberToUse1, numberToUse2));
        Sum(numberToUse1, numberToUse2)*/

        //Welcome the user to my program


        Console.WriteLine("We are using the converter. Please give me a number");

        var number1 = Console.ReadLine();
        int numberToUse1 = int.Parse(number1);

        Console.WriteLine(number1 + "minutes converted to seconds is " + Convert(numberToUse1));
        Console.WriteLine("We are going to use the add 1 function");
        var add1number = Console.ReadLine();
        int add1n = int.Parse(add1number);
        Console.WriteLine("If we add 1 to " + add1number + " we get " + add1(add1n) + ".");


    }





    public static int Sum(int number1, int number2)
    {
        return number1 + number2;
    }




    public static int Convert(int minutes)
    {
        return minutes * 60;
    }

    public static int add1(int number1)
    {
        return number1 + 1;

    }
      
}






