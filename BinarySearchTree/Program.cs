namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree");
            Node root = new Node(30);
            Node n1 = new Node(15);
            Node n2 = new Node(45);
            Node n3 = new Node(6);
            Node n4 = new Node(41);
            Node n5 = new Node(54);



            root.left = n1;
            root.right = n2;
            n1.right = n3;
            n2.left = n4;
            n3.right = n5;


            Node nodeToFind = BinarySearchTree.Search(root, 41);
            //Console.WriteLine(nodeToFind.value);

            Node newRoot = BinarySearchTree.Insert(root, 85);
            Console.WriteLine(newRoot.right.right.right.value);



        }
    }
}