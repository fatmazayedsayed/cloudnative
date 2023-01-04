// See https://aka.ms/new-console-template for more information
using Data_Structure_Decode;
Console.WriteLine("----------------Array Operations----------------");

array_operations_implementation array_Operations_Implementation = new array_operations_implementation();
int[] arr = new int[] { 1, 3, 5, 7 };
Console.WriteLine("Old Array");
Console.WriteLine(String.Join(",", arr));

array_Operations_Implementation.Resize<int>(ref arr, 7);
Console.WriteLine("New Array");
Console.WriteLine(String.Join(",", arr));

int indexOf = 40;
int item = array_Operations_Implementation.GetAt(arr, indexOf, sizeof(int));
Console.WriteLine("get the item at the index of {0} is {1}", indexOf, item);

Console.WriteLine("----------------Linked List----------------");
LinkedList linkedList = new LinkedList();
linkedList.InsertLast(1);
linkedList.InsertLast(2);
linkedList.InsertLast(7);
linkedList.InsertLast(99);
linkedList.InsertLast(90);
linkedList.PrintList();
Console.WriteLine("----------------Linked List After insertion----------------");

linkedList.InsertAfter(linkedList.FindData(2), 5);

linkedList.InsertAfter(99, 55);
linkedList.PrintList();

Console.WriteLine("----------------Linked List before insertion----------------");
linkedList.InsertBefore(linkedList.FindData(2), 10);

linkedList.PrintList();

Console.WriteLine("----------------Linked List  delete----------------");
linkedList.DeleteNode(linkedList.FindData(2));

linkedList.PrintList();

linkedList.DeleteNode(linkedList.FindData(1));

Console.WriteLine($"head is {0}",linkedList.head.data);