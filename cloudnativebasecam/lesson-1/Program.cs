// See https://aka.ms/new-console-template for more information
using lesson_1;

Console.WriteLine("calcualte area of parallelogram");
Console.WriteLine("enter the base:");
float b = float.Parse(Console.ReadLine());
Console.WriteLine("enter the Altitude:");
float h = float.Parse(Console.ReadLine());
parallelogramCalculation parallelogram = new parallelogramCalculation();
Console.WriteLine("the area for the parallelogram is: A=b*h => A=({0}*{1}={2})", b, h, parallelogram.calaArea(b, h));

Console.WriteLine("calcualte area of trapezoid");
Console.WriteLine("enter the base 1:");
float b1 = float.Parse(Console.ReadLine());
Console.WriteLine("enter the base 2:");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("enter the height:");
float height = float.Parse(Console.ReadLine());
trapezoidCalculation trapezoidCalculation = new trapezoidCalculation();
Console.WriteLine("the area for the parallelogram is:  A = ½ (a + b) h => A=( ½ ({0} + {1}){2})={3}", b1,a, height, trapezoidCalculation.calaArea(a,b, h));