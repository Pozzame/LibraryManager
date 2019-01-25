﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManager
{
    class UserInterface
    {
        const string MENU_MESSAGE = @"Inserisci:
                                        \n'S' per mostrare tutti i libri;
                                        \n'M' per mostrare i libri di un dato autore;
                                        \n'A' per aggiungere un autore;
                                        \n'B' per aggiungere un libro;
                                        \n'R' per rimuovere un autore o un libro;
                                        \n'C' per mostrare i libri di una data categoria;
                                        \n'N' per vedere il numero dei libri di un dato autore;";
        public void MainMenu()
        {
            Console.WriteLine(MENU_MESSAGE);
            string input = ReadAnswer().ToLower();

            switch (input[0])
            {
                case 's':
                    ShowAllBooks();
                    break;
                case 'm':
                    ShowBooksByAuthor();
                    break;
                case 'a':
                    AddAuthor();
                    break;
                case 'b':
                    AddBook();
                    break;
                case 'r':
                    Remove();
                    break;
                case 'c':
                    ShowByCategory();
                    break;
                case 'n':
                    NumberOfAuthorBooks();
                    break;
                default:
                    Console.WriteLine("la lettera non è valida, ritenta");
                    break;
            }
            MainMenu();
        }

        private void ShowAllBooks()
        {
            throw new NotImplementedException();
        }

        private void ShowBooksByAuthor()
        {
            throw new NotImplementedException();
        }

        private void AddAuthor()
        {
            throw new NotImplementedException();
        }

        private void AddBook()
        {
            throw new NotImplementedException();
        }

        private void Remove()
        {
            throw new NotImplementedException();
        }

        private void ShowByCategory()
        {
            throw new NotImplementedException();
        }

        private void NumberOfAuthorBooks()
        {
            throw new NotImplementedException();
        }

        private string ReadAnswer(string prompt = "")
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
        }
    }
}