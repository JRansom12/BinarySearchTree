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
        public Node Insert(Node root, int input)
        {
            if(root == null)
            {
                root = new Node();
                root.data = input;
                return root;
            }
            if(input <= root.data)
            {

                root.leftChild = Insert(root.leftChild, input);
            }
            else
            {
                root.rightChild = Insert(root.rightChild, input);
            }
            return root;
        }
        public void Add(int input)
        {
            root = Insert(root, input);
        }
        public void Search(int input)
        {
            if(input == root.data)
            {
                Console.WriteLine("Found search result: " + root.data);
            }
            else
            {
                Console.WriteLine("That input does not exist in this tree.");
            }
        }        
    }
}
