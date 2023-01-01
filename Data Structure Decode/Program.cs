// See https://aka.ms/new-console-template for more information
using Data_Structure_Decode;

array_operations_implementation array_Operations_Implementation = new array_operations_implementation();
int[] arr = new int[] { 1, 3, 5, 7 };
Console.WriteLine("Old Array");
Console.WriteLine(String.Join(",", arr));

array_Operations_Implementation.Resize<int>(ref arr, 7);
Console.WriteLine("New Array");
Console.WriteLine(String.Join(",",arr ));

