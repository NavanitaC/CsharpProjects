﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackInterface
{
    interface IStack
    {
        void Push(int v);
        int Pop();
        int Length { get; }
    }
    class StackFullException : Exception
    {
        public StackFullException(): base("Stack Full")
        {
        }
    }
    class StackEmptyException : Exception
    {
        public StackEmptyException() : base("Stack Empty")
        {
        }
    }
    class  Stack:IStack
    {
        private int[] a = new int[10];
        private int top = 0;

        public void Push(int v)
        {
            if (top == 10)
                throw new StackFullException();
            a[top] = v;
            top++;
        }

        public int Pop()
        {
            if (top == 0)
                throw new StackEmptyException();
            top--;
            return a[top];
        }

        public int Length
        {
           get
            {
                return top;
            }
        }
    }

}
