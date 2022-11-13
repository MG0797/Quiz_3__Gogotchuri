using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    public class CustomQueue<T> : Exception
    {
        private readonly List<T>? _queue;

        public CustomQueue(List<T>? queue)
        {
            _queue = queue;
        }

        public CustomQueue(int capacity)
        {
            _queue = new List<T>(capacity);
        }

        public void Push(T element)
        {
            _queue!.Add(element);
        }
        public T Pop()
        {
            if (_queue == null || _queue?.Count == 0)
            {
                throw new IndexOutOfRangeException("Queue is empty");
            }

            T element = _queue![^1];
            _queue.RemoveAt(_queue.Count - 1);

            return element;
        }

    }
}
