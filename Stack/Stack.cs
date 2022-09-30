namespace Stack
{
    public class Stack<T>
    {
        List<T> items = new List<T>();
        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            T item = items[^1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        public int Size()
        {
            return items.Count;
        }
    }
}