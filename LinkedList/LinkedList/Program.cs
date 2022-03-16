using MyLinkedList;

var linkedList = new MyLinkedList<int>();

linkedList.Add(1);
linkedList.Add(3);
linkedList.Add(2);
linkedList.Add(5);

//Console.WriteLine();



//linkedList.ReverseWithIteration();

int input = int.Parse(Console.ReadLine());

linkedList.ReverseWithRecursion();

//Console.WriteLine(linkedList.Mth(input));

Console.WriteLine();