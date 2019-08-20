using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        // member variables
        public Node root;

        // constructor
        public BinarySearchTree()
        {
            root = null;           
        }

        // member methods
        public void Add(int input)
        {
            Node newNode = new Node();
            newNode.data = input;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (input < current.data)
                    {
                        current = current.leftChild;
                        if (current == null)
                        {
                            parent.leftChild = newNode;
                            break;
                        }
                    }
                    else
                    {
                        current = current.rightChild;
                        if (current == null)
                        {
                            parent.rightChild = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public void Search(int input)
        {
            SearchTree(root, input);
        }
        public Node SearchTree(Node root, int input)
        {
            while (true)
            {
                if (root == null)
                {
                    Console.WriteLine("This value does not exist in this tree.");
                    return null;
                }
                else if (input == root.data)
                {
                    Console.WriteLine("This value does exist in this tree.");
                    return root;
                }
                else
                {
                    return (root.data > input) ? SearchTree(root.leftChild, input) : SearchTree(root.rightChild, input);
                }
            }
        }       
    }
}
