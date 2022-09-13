// See https://aka.ms/new-console-template for more information
using Method_Excercise;
Methods.Excercise1();

Methods.AddBreak();

//ADD
Console.Write($"Addition Answer: ");
Console.WriteLine(Methods.Add(20, 5));
Methods.AddSmallBreak();

Console.Write($"Subtraction Answer : ");
Console.WriteLine(Methods.Subtract(30, 5));
Methods.AddSmallBreak();

Console.Write($"Multiplication Answer : ");
Console.WriteLine(Methods.Multiply(5, 5));
Methods.AddSmallBreak();

Console.Write($"Division Answer: ");
Console.WriteLine(Methods.Divide(125, 5));
Methods.AddSmallBreak();

Console.Write($"Modulus Answer: ");
Console.WriteLine(Methods.Modulus(125,10));
Methods.AddSmallBreak();

Console.Write($"Sum(2,4) Answer: ");
Console.WriteLine(Methods.Sum(2, 4));

Console.Write($"Sum(2,4,6) Answer: ");
Console.WriteLine(Methods.Sum(2, 4, 6));

Console.Write($"Sum(1,1,1,1,1) Answer: ");
Console.WriteLine(Methods.Sum(1, 1, 1, 1, 1));
