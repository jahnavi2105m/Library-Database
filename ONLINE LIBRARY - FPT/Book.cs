using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class Book
    {
        private int bookID;
        private int ISBN;
        private string title;
        private string author;
        private int numOfBookReaders;
        private int rating;

        public Book()
        {
        }
        public void setbookID(int bookID)
        {
            this.bookID = bookID;
        }
        public int getbookID()
        {
            return this.bookID;
        }
        public void setISBN(int ISBN)
        {
            this.ISBN = ISBN;
        }
        public int getISBN()
        {
            return this.ISBN;
        }
        public void setTitle(string title)
        {
            this.title = title;
        }
        public string getTitle()
        {
            return this.title;
        }
        public void setAuthor(string author)
        {
            this.author = author;
        }
        public string getAuthor()
        {
            return this.author;
        }
        public void setNumOfBookReaders(int numOfBookReaders)
        {
            this.numOfBookReaders = numOfBookReaders + 1; 
        }
        public int getNumOfBookReaders()
        {
            return numOfBookReaders;
        }
        public void setRating(int rating)
        {
            this.rating = rating;
        }
        public int getRating()
        {
            return this.rating;
        }
    }
}
