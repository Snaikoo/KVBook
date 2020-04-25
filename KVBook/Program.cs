using System;
using System.Collections.Generic;
using System.Linq;

namespace KVBook
{
    class Book
    {
        public string Name;
        public string Author;
        public int Price;
    }
    static class Librarium
    {
        static public Book[] BookShop = new Book[Size];
        static public int Size;
        static public void Booking()
        {
            Console.Write("Размер массива = ");
            Size = Convert.ToInt32(Console.ReadLine());
            int gnome = 0;
            foreach (Book i in BookShop)
            {                
                Console.Write("Название книги №", gnome, " = ");
                i.Name = Console.ReadLine();
                Console.Write("Автор книги №", gnome, " = ");
                i.Author = Console.ReadLine();
                Console.Write("Цена книги №", gnome, " = ");
                i.Price = Convert.ToInt32(Console.ReadLine());
            }
        }
        static public void Sort()
        { 
            BookShop.OrderBy(r => r.Price).ThenBy(r => r.Author).ToArray();
        }

    
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
