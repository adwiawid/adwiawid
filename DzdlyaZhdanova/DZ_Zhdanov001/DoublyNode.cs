using System;
using System.Collections.Generic;
using System.Text;

namespace DzdlyaZhdanova
{
    class DoublyNode <T>
    {
        public T Data { get; internal set; }
        public DoublyNode<T> Previous { get; internal set; }
        public DoublyNode<T> Next { get; internal set; }
        public object Value { get; internal set; }
    }
}
