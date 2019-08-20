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
        public Node Search(Node root, int input)
        {
            if (root == null)
            {
                return null;
            }
            if (root.data == input)
            {
                return root;
            }
            else
            {
                return (root.data > input) ? Search(root.leftChild, input) : Search(root.rightChild, input);
            }
        }       
    }
}
