﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Node
    {
        public int data;
        public Node next;
        // Constructor to create a new node
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

}
