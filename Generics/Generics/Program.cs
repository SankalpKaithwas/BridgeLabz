using System;

namespace Generics
{
    public class Book
    {
        public void Add(Book book)
        {
            throw new NullReferenceException();
        }
        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
    public class GenericDictionary<TKey, TVlaue>
    {
        public void Add(TKey key, TVlaue value)
        {

        }
    }
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }
        public T this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new GenericList<int>();
            numbers.Add(4);

            var books = new GenericList<Book>();
                books.Add(new Book());

            var dictionary = new GenericDictionary<string, Book>();
            dictionary.Add("1234", new Book());
        }
    }
}
