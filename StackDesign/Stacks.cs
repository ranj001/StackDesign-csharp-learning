namespace StackDesign
{
    public class Stacks
    {
        private object[] _items;
        private int _count;
        private const int DefaultCapacity = 4;
        public Stacks()
        {
            _items = new object[DefaultCapacity];
            _count = 0;
        }
       
        public void Push(object item)
        {
            if (item == null)
                throw new InvalidOperationException("Item cannot be null.");

            if (_count == _items.Length)
                Resize(_items.Length * 2);

            _items[_count++] = item;
        }
        public object Pop()
        {
            if (_count == 0)
                throw new InvalidOperationException("Stack is empty.");

            object item = _items[--_count];
            _items[_count] = null; // Clear the reference

            if (_count > 0 && _count == _items.Length / 4)
                Resize(_items.Length / 2);

            return item;
        }
        public void PeekAll()
        {
            if (_count == 0)
                throw new InvalidOperationException("Stack is empty.");

            for (int i = _count - 1; i >= 0; i--)
            {
                if (_items[i] == null)
                    break;
                Console.WriteLine(_items[i]);
            }

        }
        public void Clear()
        {
            _items = new object[DefaultCapacity];
            _count = 0;
        }
        public int Count()
        { 
            return _items.Length + 1;
        }
        public int StackCounter => _items.Length;
        private void Resize(int newCapacity)
        {
            object[] newArray = new object[newCapacity];
            Array.Copy(_items, newArray, _count);
            _items = newArray;
        }

    }
}