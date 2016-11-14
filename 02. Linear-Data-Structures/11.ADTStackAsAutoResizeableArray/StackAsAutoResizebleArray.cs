using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ADTStackAsAutoResizeableArray
{
    public class StackAsAutoResizebleArray<T>
    {
        private int maxLength;
        private T[] stack;
        private T[] arrayToResize;
        private int top = 0;

        public StackAsAutoResizebleArray()
        {
            maxLength = 10;
            this.stack = new T[maxLength];
        }

        public void Push(T element)
        {
            if (maxLength == top)
            {
                //arrayToResize = stack;
                //stack = new T[maxLength * 2];
                //stack = arrayToResize;
                Array.Resize(ref this.stack, maxLength * 2);
            }

            stack[top++] = element;
        }

        public T Pop()
        {
            if (top == 0)
            {
                throw new IndexOutOfRangeException("Stack is empty");
            }

            return stack[--top];
        }

        public bool IsEmpty()
        {
            return 0 == top;
        }

        public T[] Stack
        {
            get
            {
                return this.stack;
            }

            set
            {
                this.stack = value;
            }
        }
    }
}
