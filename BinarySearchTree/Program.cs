﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree redCedar = new BinarySearchTree();
            redCedar.Add(50);
            redCedar.Search(50);
        }
    }
}
