﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLinkedList
{
    public class Node<T>
    {
        public Node<T>? next;
        public Object data;
        
        public Node(Object _data)
        {
            data = _data;
            next = null;
        }

    }
}
