using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace KVBook
{
    class Book
    {
        public string Name = "";
        public string Author = "";
        public int Price = 0;
    }
    static class Librarium
    {
        
        static public int Size;
        static public List<Book> BookShop = new List<Book>();
        static public void Booking()
        {
            Console.Write("Размер массива = ");
            Size = Convert.ToInt32(Console.ReadLine());     
            for (int i = 0; i < Size; i++)
            {
                Book TempBook = new Book();
                Console.Write("Название книги №" + i + " = ");
                TempBook.Name = Console.ReadLine().ToString();
                Console.Write("Автор книги №" + i + " = ");
                TempBook.Author = Console.ReadLine().ToString();
                bool hasLetters;
                do
                {
                    Console.Write("Цена книги №" + i + " = ");
                    string t = Console.ReadLine();
                    hasLetters = t.AsEnumerable().Any(ch => char.IsLetter(ch));
                    if (!hasLetters)
                        TempBook.Price = Convert.ToInt32(t);
                    else
                    {
                        Console.Write("Цена не должна содержать буквы. Только цифры. Повторите ввод цены для книги №" + i + " = ");
                    }
                }
                while (hasLetters);
                BookShop.Add(TempBook);
            }
        }
        static public void Sort()
        { 
            BookShop.OrderBy(r => r.Price).ThenBy(r => r.Author).ToArray();
        }
        static public void SaveInFile()
        {
            using (StreamWriter sw = new StreamWriter("BookShelf.txt"))
            {
                foreach(Book B in BookShop)
                sw.WriteLine(B.Author + ", " + B.Name + ", " + B.Price.ToString());
            }
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Librarium.Booking();
            Librarium.Sort();
            Librarium.SaveInFile();

        }
    }
}
