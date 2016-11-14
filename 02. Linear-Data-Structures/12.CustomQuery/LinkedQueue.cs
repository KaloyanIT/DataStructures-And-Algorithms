using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _12.CustomQuery
{
    public class LinkedQueue<T> : IEnumerable<T>
    {
        private int front;
        private int rear;
        private List<T> queue;

        public LinkedQueue()
        {
            this.queue = new List<T>();
        }

        public void Put(T Element)
        {
            this.queue.Add(Element);
        }

        public T Get()
        {
            if (this.queue.Count <= 0)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }
            var item = this.queue.FirstOrDefault();
            this.queue.Remove(item);

            return item;
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}