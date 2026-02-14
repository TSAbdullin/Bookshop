using System;
using System.Collections.Generic;
using System.IO;

namespace Bookshop.Classes
{
    internal class Library
    {
        public static List<Book> Books {  get; set; } = new List<Book>();
        
        public void AddBook()
        {

        }

        public static void LoadBooks(string pathToBooks)
        {
            if (!File.Exists(pathToBooks))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesBooks = File.ReadAllLines(pathToBooks);


            for (int i = 0; i < linesBooks.Length; i++)
            {
                string[] parts = linesBooks[i].Split('.');
                string[] partsData = parts[1].Split(',');

                string title = partsData[0].Trim();

                if (!long.TryParse(partsData[1].Trim(), out long authorId)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID автора"); 
                }

                if (!long.TryParse(partsData[2].Trim(), out long genreId)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID жанра"); 
                }

                if (!bool.TryParse(partsData[3].Trim(), out bool hasDiscount)) 
                { 
                    throw new ArgumentException("Не удалось запарсить наличие скидки"); 
                }

                if (!long.TryParse(parts[0].Trim(), out long id)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID книги"); 
                }

                Books.Add(new Book(id, title, authorId, genreId, hasDiscount));
            }
        }
    }
}