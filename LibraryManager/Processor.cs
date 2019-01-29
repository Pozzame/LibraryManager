using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManager
{
    partial class Processor
    {
        internal void ShowAllBooks()
        {
            try
            {
                using (var context = new LibraryContext())
                {
                    //    foreach (var b in context.Books)
                    //    {
                    //        var idA = b.AuthorId;
                    //        var find = context.Authors.Find(idA);

                    //        Console.WriteLine($"ID: {b.BookId} - Titolo: {b.Title}, Autore: {find.FirstName + " " + find.LastName}, Categoria: {b.Category};");
                    //    }

                    Book libbro = context.Books.Find(1);

                    Console.WriteLine($"ID: {libbro.BookId} - Titolo: {libbro.Title}, Categoria: {libbro.Category};");

                    libbro.Title = libbro.Title + "1";

                    Console.WriteLine($"ID: {libbro.BookId} - Titolo: {libbro.Title}, Categoria: {libbro.Category};");

                    using (var context1 = new LibraryContext())
                    {
                        Book libbro1 = context1.Books.Find(1);
                        libbro1.Title = libbro1.Title + "2";
                        context1.SaveChanges();

                        Console.WriteLine($"ID: {libbro1.BookId} - Titolo: {libbro1.Title}, Categoria: {libbro1.Category};");
                    }

                    context.SaveChanges();

                    Console.WriteLine($"ID: {libbro.BookId} - Titolo: {libbro.Title}, Categoria: {libbro.Category};");
                }
            }
            catch (DbUpdateException)
            {
                using (var context2 = new LibraryContext())
                {
                    Book libbrow = context2.Books.Find(1);
                    Console.WriteLine($"ECCEZIONE!!!!!!!!!!\nID: {libbrow.BookId} - Titolo: {libbrow.Title}, Categoria: {libbrow.Category};");
                }
            }
        }

        internal void ShowBookByAuthor()
        {
            using (var context = new LibraryContext())
            {
                foreach (var a in context.Authors)
                {
                    Console.WriteLine($"ID: {a.AuthorID}, Nome: {a.FirstName}, Cognome: {a.LastName};");
                }
                int choice = Int32.Parse(ReadAnswer("Inserisci l'ID: "));
                foreach (var b in context.Books)
                {
                    if (b.AuthorId == choice)
                    {
                        Console.WriteLine($"Titolo: {b.Title}, Categoria: {b.Category}");
                    }
                }
            }
        }

        internal void AddBook(string input)
        {
            using (var context = new LibraryContext())
            {
                // Controllare cosa succede se si inserisce un nome di autore esistente
                var i = input.Split(' ');
                var author = new Author
                {
                    FirstName = i[0],
                    LastName = i[1],
                    Books = new List<Book>
                    {
                        new Book {Title = ReadAnswer("Inserisci il titolo del libro: "),
                                  Category = ReadAnswer("Inserisci la categoria del libro: "),
                                  StoreId = Int32.Parse(ReadAnswer("Inserisci l'ID dello store: "))
                        }
                    }
                };
                context.Add(author);
                context.SaveChanges();
            }
        }

        internal void RemoveBook()
        {
            using (var context = new LibraryContext())
            {
                ShowAllBooks();
                int input = Int32.Parse(ReadAnswer("Inserisci l'ID: "));
                context.Remove(context.Books.Find(input));
                context.SaveChanges();
            }
        }

        internal void RemoveAuthor()
        {
            using (var context = new LibraryContext())
            {
                foreach (var a in context.Authors)
                {
                    Console.WriteLine($"ID: {a.AuthorID}, Nome: {a.FirstName}, Cognome: {a.LastName};");
                }
                int input = Int32.Parse(ReadAnswer("Inserisci l'ID: "));
                context.Remove(context.Authors.Find(input));
                context.SaveChanges();
            }
        }

        internal void AddInStore()
        {
            // Stampa lista magazzini
            // Scegli l'ID del magazzino
            // Assegna al libro
        }

        internal void BookInStore()
        {
        }

        private string ReadAnswer(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}
