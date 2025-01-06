namespace Generics
{
    public class Jar<T>
    {
        private Stack<T> elements;

        public Jar()
        {
            elements = new Stack<T>();
        }

        public void Add(T element)
        {
            elements.Push(element);
        }

        public T Remove()
        {
            if (elements.Count == 0)
            {
                throw new InvalidOperationException("The jar is empty.");
            }

            return elements.Pop();
        }
    }
}
