using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BrokenLink
{
    public class Node
    {
        public string Value { get; set; }
        public Node Next { get; set; }
    }

    // Implement linked list data structure and all missing public members of it
    public class QuackedList
    {
        private Node _head; // -\_(O.o)_/-

        public string Head
        {
            get
            {
                return _head.Value;
                // should return first element of list
            }
        }

        public int Count
        {
            get
            {
                Node current = _head;
                int count = 0;
                while (current != null) {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public void Add(string item)
        {
            if (_head == null) {
                _head = new Node();
                _head.Value = item;
                _head.Next = null;
            }
            else {
                Node newNode = new Node();
                newNode.Value = item;

                Node current = _head;
                while (current.Next != null) {
                    current = current.Next;
                }
                current.Next = newNode;

            }
        }

        public void Remove(string item)
        {
            Node current = _head;
            Node previous = null;

            while (current != null) {
                if (current.Value == item) {
                    if (previous != null) {
                        previous.Next = current.Next;
                        current = current.Next;
                    }
                    else {
                        previous = current;
                        current = current.Next;
                        _head = current;
                    }
                }
                else {
                    previous = current;
                    current = current.Next;
                } 
            }

        }

        public void RemoveAt(int index)
        {
            int currentIndex = 0;
            Node current = _head;
            Node lastNode = null;

            if (index == 0) {
                _head = current.Next;
                return;
            }
            else if (index >= 1 && index <= Count) {
                while (current != null) {
                    if (index == currentIndex) {
                        lastNode.Next = current.Next;
                        return;
                    }
                    currentIndex++;
                    lastNode = current;
                    current = current.Next;
                }
            }
        }

        public override string ToString()
        {
            // should print all members separated by comma (CSV format) - 1,2,3,4
            string myString = "";

            if (_head == null || _head.Value == null) {
                return myString;
            }
            else {
                Node current = _head;
                while (current != null) {
                    if (myString == "") {
                        myString = current.Value;
                    }
                    else {
                        myString = myString + "," + current.Value;
                    }
                    current = current.Next;
                }
                return myString;
            }
        }

        public string ToStringReverse()
        {
            // should print all members separated by comma in reverse order (figure the best and most performant way) - 4,3,2,1
            string myString = "";

            if (_head == null || _head.Value == null)
            {
                return myString;
            }
            else
            {
                Node current = _head;
                while (current != null)
                {
                    if (myString == "")
                    {
                        myString = current.Value;
                    }
                    else
                    {
                        myString = current.Value + "," + myString;
                    }
                    current = current.Next;
                }
                return myString;
            }
        }

        public string this[int index] // indexer
        {
            get
            {
                Node current = _head;

                if (index == 0 && _head != null) {
                    return current.Value;

                }
                else if (_head != null) {
                    int count = 0;

                    while (current.Next != null) {
                        if (count == index) {
                            return current.Value;
                        }
                        count++;
                        current = current.Next;
                    }
                }
                throw new IndexOutOfRangeException();
            }
        }
    }
}
