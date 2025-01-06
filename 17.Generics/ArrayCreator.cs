namespace Generics
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int length, T item)
        {
            T[] array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }

            return array;
        }

        public static T[] Create<T>(Type classType, int length, T item)
        {
            if (!typeof(T).IsAssignableFrom(classType))
            {
                throw new ArgumentException($"The class type {classType} is not assignable to {typeof(T)}.");
            }

            T[] array = new T[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}
