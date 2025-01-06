namespace Generics
{
    public class Scale<T> where T : IComparable<T>
    {
        private T left;
        private T right;

        public Scale(T leftElement, T rightElement)
        {
            left = leftElement;
            right = rightElement;
        }

        public T GetHeavier()
        {
            int comparison = left.CompareTo(right);

            if (comparison > 0)
            {
                return left;
            }
            else if (comparison < 0)
            {
                return right;
            }

            return default;
        }
    }
}
