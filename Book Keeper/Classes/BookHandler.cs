﻿using Book_Keeper.BookKeeperSR;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Keeper.Classes
{
    class BookHandler
    {
        private BookKeeperSR.Service1Client wcfService;
        private BookModel[] books;
        private AuthorModel[] authors;

        public BookHandler()
        {
            wcfService = new BookKeeperSR.Service1Client();
            authors = wcfService.getAuthors().ToArray();
            books = wcfService.GetBooks().ToArray();

        }

        /**
         * Finds a single book in the books array by the book id
         *
         * @return BookModel
         */
        public BookModel getBookByID(int id)
        {
            foreach(BookModel book in books)
            {
                if (book.Bookid == id)
                {
                    return book;
                }
            }

            return null;
        }


        /**
         * Gets the total amount of stock across all books
         *
         * @return int
         */
        public int getTotalStock()
        {
            int stock = 0;

            foreach (BookModel book in books)
            {
                stock += book.Stock;
            }

            return stock;
        }

        /**
         * Gets the total amount of stock price across all books
         *
         * @return decimal
         */
        public decimal getTotalStockPrice()
        {
            decimal price = 0;

            foreach (BookModel book in books)
            {
                price += (book.Stock * book.Price);
            }

            return price;
        }

        /**
         * Combines inputs given by the user into a BookModel and sends to the WCF service handler to add to the database
         *
         * @return bool
         */
        public bool AddBook(string authorName, string bookTitle, string pricein, string stockin)
        {
            //Converting the string values stock to int and price to decimal
            int stock = Convert.ToInt32(stockin);
            decimal price = decimal.Parse(pricein, NumberStyles.Currency);

            //Adding the data to the BookModel
            List<AuthorModel> authors = new List<AuthorModel>();
            authors.Add(new AuthorModel { Name = authorName});
            BookModel book = new BookModel();
            book.Authors = authors.ToArray();
            book.Title = bookTitle;
            book.Stock = stock;
            book.Price = price;

            wcfService.AddBook(book);

            return true;
        }
    }
}
