using _2.LinkedList;

var node = LinkedListOperations.StartLinkedList();

LinkedListOperations.AddNode(new Node("E", null));
//LinkedListOperations.InsertNodeInPosition(new Node("E", null), 2);
//LinkedListOperations.RemoveNodeInPosition(1);

LinkedListOperations.ShowLinkedList(node);

Console.ReadKey();