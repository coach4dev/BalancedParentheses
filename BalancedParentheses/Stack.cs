using System;
using System.Collections.Generic;
using System.Text;

namespace BalancedParentheses
{
    class Stack
    {
        public static int MAX = 1000;
        public static int MIN = -1;
        public int top = MIN;
        public char[] items = new char[MAX];

        public void Push(char input)
        {
            if (top == MAX - 1)
                throw new Exception("Trying to push to a full stack");
            top++;
            items[top] = input;
        }

        public char Pop()
        {
            if (top == MIN)
                throw new Exception("Trying to pop an empty stack");

            char result = items[top];
            top--;
            return result;
        }

        public bool IsEmpty()
        {
            if (top == MIN)
                return true;

            return false;
        }
    }
}