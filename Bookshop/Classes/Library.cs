using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace Bookshop.Classes
{
    public class Library
    {
        public static List<Book> books {  get; set; } = new List<Book>();
        public static Dictionary<long, Genre> genresById { get; set; } = new Dictionary<long, Genre>();
        public static Dictionary<long, Author> authorsById { get; set; } = new Dictionary<long, Author>();


        public void AddBook()
        {

        }

        /// <summary>
        /// Метод, который подгружает все книги из файла
        /// </summary>
        /// <param name="pathToBooks"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void LoadBooks(string pathToBooks) // Сложность O(N)
        {
            if (!File.Exists(pathToBooks))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesBooks = File.ReadAllLines(pathToBooks);

            /*
             Поскольку в названии книг обычно не ставятся точки
            было принято решение сделать разделение через Split по точке, 
            тем самым разделить ID книги и информацию о книге
             */

            for (int i = 0; i < linesBooks.Length; i++) 
            {
                string[] parts = linesBooks[i].Split('.'); 
                string[] partsData = parts[1].Split(',');

                string title = partsData[0].Trim();

                #region Проверка на возможность запарсить данные из файла
                if (!long.TryParse(partsData[1].Trim(), out long authorId)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID автора, при загрузке книг"); 
                }

                if (!long.TryParse(partsData[2].Trim(), out long genreId)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID жанра, при загрузке книг"); 
                }

                if (!bool.TryParse(partsData[3].Trim(), out bool hasDiscount)) 
                { 
                    throw new ArgumentException("Не удалось запарсить наличие скидки, при загрузке книг"); 
                }

                if (!long.TryParse(parts[0].Trim(), out long id)) 
                { 
                    throw new ArgumentException("Не удалось запарсить ID книги"); 
                }
                #endregion

                books.Add(new Book(id, title, authorId, genreId, hasDiscount));
            }
        }

        public static void LoadGenres(string pathToGenres) // Сложность O(N)
        {
            if (!File.Exists(pathToGenres))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesGenres = File.ReadAllLines(pathToGenres);

            /*
             Поскольку в названии книг обычно не ставятся точки
            было принято решение сделать разделение через Split по точке, 
            тем самым разделить ID книги и информацию о книге
             */

            for (int i = 0; i < linesGenres.Length; i++)
            {
                string[] parts = linesGenres[i].Split('.');
                string title = parts[1].Trim();
                
                if (!long.TryParse(parts[0], out long genreId))
                {
                    throw new ArgumentException("Не удалось запарсить ID жанра, при загрузке жанров");
                }
                
                genresById.Add(genreId, new Genre(genreId, title));
            }
        }

        public static void LoadAuthors(string pathToAuthors) // Сложность O(N)
        {
            if (!File.Exists(pathToAuthors))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesAuthors = File.ReadAllLines(pathToAuthors);

            /*
             Поскольку в названии книг обычно не ставятся точки
            было принято решение сделать разделение через Split по точке, 
            тем самым разделить ID книги и информацию о книге
             */

            for (int i = 0; i < linesAuthors.Length; i++)
            {
                string[] parts = linesAuthors[i].Split('.');
                string name = parts[1].Trim();

                if (!long.TryParse(parts[0], out long authorId))
                {
                    throw new ArgumentException("Не удалось запарсить ID жанра, при загрузке жанров");
                }

                authorsById.Add(authorId, new Author(authorId, name));
            }
        }

        public static string GetGenreName(long genreId)
        {
            if (genresById.TryGetValue(genreId, out var genres))
            {
                return genres.Name;
            }
            else { throw new ArgumentException("Не найден жанр!"); }
        }

        public static string GetAuthorName(long authorId)
        {
            if (authorsById.TryGetValue(authorId, out var author))
            {
                return author.Name;
            }
            else { throw new ArgumentException("Не найден автор!"); }
        }
    }
}