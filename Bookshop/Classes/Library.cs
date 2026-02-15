using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace Bookshop.Classes
{
    public class Library
    {
        public static BindingList<Book> books {  get; set; } = new BindingList<Book>();
        public static Dictionary<long, Genre> genresById { get; set; } = new Dictionary<long, Genre>();
        public static Dictionary<long, Author> authorsById { get; set; } = new Dictionary<long, Author>();

        /// <summary>
        /// Метод, который позволяет создать книгу
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="genre"></param>
        /// <param name="hasDiscount"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void AddBook(string title, string author, string genre, bool hasDiscount)
        {
            var authorId = GetAuthorId(author);
            var genreId = GetGenreId(genre);

            if (authorId == -1)
            {
                throw new ArgumentException("Такого автора не существует!");
            }

            books.Add(new Book(title, authorId, genreId, hasDiscount));
        }

        /// <summary>
        /// Метод, который позволяет удалять книгу 
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        public static bool DeleteBook(long idBook)
        {
            foreach (var book in books)
            {
                if (book.Id == idBook)
                {
                    books.Remove(book);
                    return true;
                }
            }
            return false;
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

        /// <summary>
        /// Метод, который подгружает жанры из файла
        /// </summary>
        /// <param name="pathToGenres"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void LoadGenres(string pathToGenres) // Сложность O(N)
        {
            if (!File.Exists(pathToGenres))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesGenres = File.ReadAllLines(pathToGenres);


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

        /// <summary>
        /// Метод, который подгружает авторов из файла
        /// </summary>
        /// <param name="pathToAuthors"></param>
        /// <exception cref="ArgumentException"></exception>
        public static void LoadAuthors(string pathToAuthors) // Сложность O(N)
        {
            if (!File.Exists(pathToAuthors))
            {
                throw new ArgumentException("Путь не найден!");
            }

            string[] linesAuthors = File.ReadAllLines(pathToAuthors);

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

        /// <summary>
        /// Метод, который позволяет получить название жанра по идентификатору жанра
        /// </summary>
        /// <param name="genreId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetGenreName(long genreId) // O(1)
        {
            if (genresById.TryGetValue(genreId, out var genres))
            {
                return genres.Name;
            }
            else { throw new ArgumentException("Не найден жанр!"); }
        }

        /// <summary>
        /// Метод, который позволяет получить название автора по идентификатору автора
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetAuthorName(long authorId) // O(1)
        {
            if (authorsById.TryGetValue(authorId, out var author))
            {
                return author.Name;
            }
            else { throw new ArgumentException("Не найден автор!"); }
        }

        /// <summary>
        /// Метод, возвращающий айди автора по его имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static long GetAuthorId(string name) // в худшем случае O(N), в лучшем O(1)
        {
            foreach (var pair in authorsById)
            {
                if (pair.Value.Name == name)
                {
                    return pair.Key;
                }
            }
            return -1;
        }

        public static long GetGenreId(string genre) // в худшем случае O(N), в лучшем O(1)
        {
            foreach (var pair in genresById)
            {
                if (pair.Value.Name == genre)
                {
                    return pair.Key;
                }
            }
            return -1;
        }
    }
}