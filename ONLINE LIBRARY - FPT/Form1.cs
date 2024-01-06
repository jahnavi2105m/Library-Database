using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<Book> booklist = new List<Book>();
        List<User> userlist = new List<User>();
        bool signedin = false;
        StreamReader b1234 = new StreamReader("b1234.txt");
        StreamReader b1235 = new StreamReader("b1235.txt");
        StreamReader b1236 = new StreamReader("b1236.txt");
        StreamReader b1237 = new StreamReader("b1237.txt");


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {
            textBoxDisplayAdmin.Clear();

            foreach (Book book in booklist) //to display all the books to admin
            {
                textBoxDisplayAdmin.AppendText("Book title: " + book.getTitle());
                textBoxDisplayAdmin.AppendText(Environment.NewLine);
                textBoxDisplayAdmin.AppendText("Author: " + book.getAuthor());
                textBoxDisplayAdmin.AppendText(Environment.NewLine);
                textBoxDisplayAdmin.AppendText("ID number: " + book.getbookID());
                textBoxDisplayAdmin.AppendText(Environment.NewLine);
                textBoxDisplayAdmin.AppendText("ISBN: " + book.getISBN());
                textBoxDisplayAdmin.AppendText(Environment.NewLine);
                textBoxDisplayAdmin.AppendText(Environment.NewLine);

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            bool f = false;
            try
            {
                if (textBoxTitle.Text != "" && textBoxAuthor.Text != "") //to add book to list
                {
                    book.setTitle(textBoxTitle.Text);
                    book.setAuthor(textBoxAuthor.Text);
                    f = true;
                }
                else MessageBox.Show("Please fill out all the fields", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                book.setbookID(int.Parse(textBoxID.Text));
                book.setISBN(int.Parse(textBoxISBN.Text));
                if (f == true)
                {
                    booklist.Add(book); 
                    MessageBox.Show("Book added!", "", MessageBoxButtons.OK);
                    textBoxTitle.Clear();
                    textBoxAuthor.Clear();
                    textBoxID.Clear();
                    textBoxISBN.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Input book ID and ISBN as a number", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool f = false;
            Book savebook = new Book();
            foreach (Book book in booklist) //to delete a book
            {
                if (book != null && book.getbookID() == int.Parse(textBoxID.Text))
                {
                    savebook = book;
                    f = true;
                }
            }
            if (f == true)
            {
                booklist.Remove(savebook);
                MessageBox.Show("Book deleted successfully", "", MessageBoxButtons.OK);
                textBoxTitle.Clear();
                textBoxAuthor.Clear();
                textBoxID.Clear();
                textBoxISBN.Clear();
                textBoxDisplayAdmin.Clear();
            }
            else MessageBox.Show("Book ID not found", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            bool f = false;
            foreach (Book book in booklist) //to edit a book
            {
                try
                {
                    if (book != null && book.getbookID() == int.Parse(textBoxID.Text))
                    {
                        f = true;
                        if (textBoxTitle.Text != "")
                            book.setTitle(textBoxTitle.Text);
                        if (textBoxAuthor.Text != "")
                            book.setAuthor(textBoxAuthor.Text);
                        if (textBoxISBN.Text != "")
                        {
                            MessageBox.Show("ISBN cannot be changed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            textBoxISBN.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Edits saved successfully", "", MessageBoxButtons.OK);
                            textBoxTitle.Clear();
                            textBoxAuthor.Clear();
                            textBoxID.Clear();
                            textBoxISBN.Clear();
                            textBoxDisplayAdmin.Clear();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Book ID not found", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
            if (f == false)
                MessageBox.Show("Book ID not found", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void buttonDisplayUsers_Click(object sender, EventArgs e)
        {
            textBoxDisplayAdmin.Clear();
            foreach (User user in userlist) //to display all the users to the admin
            {
                textBoxDisplayAdmin.AppendText(user.getUsername());
                textBoxDisplayAdmin.AppendText(Environment.NewLine);
            }
        }

        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.setUsername(textBoxUsernameSU.Text); //for the user to create an account
            user.setPassword(textBoxPasswordSU.Text);
            
                if (user.getPassword() == textBoxPasswordConfirm.Text && textBoxPasswordConfirm.Text != "")
                {
                    userlist.Add(user);
                    MessageBox.Show("Account created succesfully! Sign in to continue", "", MessageBoxButtons.OK);
                    textBoxUsernameSU.Clear();
                    textBoxPasswordSU.Clear();
                    textBoxPasswordConfirm.Clear();
                }
                else
                {
                    MessageBox.Show("Password does not match", "", MessageBoxButtons.OK, MessageBoxIcon.Error); //the password confirmation must match to create the account
                    textBoxPasswordConfirm.Clear();
                }
            }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
           
            Book savebook = new Book();
            bool f = false;
            textBoxDisplayUser.Clear();
            foreach (Book book in booklist) //searching for book by title or author
            {
                if (book.getTitle() == textBoxSearch.Text && book.getTitle() != null || book.getAuthor() == textBoxSearch.Text && book.getAuthor() != null)
                {
                    int n = book.getNumOfBookReaders();
                    if(book.getbookID() == 1234)
                        textBoxDisplayUser.Text = b1234.ReadToEnd();
                    if (book.getbookID() == 1235)
                        textBoxDisplayUser.Text = b1235.ReadToEnd();
                    if (book.getbookID() == 1236)
                        textBoxDisplayUser.Text = b1236.ReadToEnd();
                    if (book.getbookID() == 1237)
                        textBoxDisplayUser.Text = b1237.ReadToEnd();
                    f = true;
                   book.setNumOfBookReaders(n);
                    savebook = book;
                    numericUpDown1.Maximum = 10;
                    numericUpDown1.Minimum = 1;
                    numericUpDown1.Value = 1;
                    buttonSubmitRating.Enabled = true;
                    numericUpDown1.Enabled = true;
                }                
            }
           
            if (f == false)
                MessageBox.Show("Book does not exist in the library", "", MessageBoxButtons.OK, MessageBoxIcon.Question);
            
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            
            foreach (User user in userlist)
            {
                if (user.getUsername() == textBoxUsername.Text && user.getPassword() == textBoxPassword.Text)
                {
                    signedin = true;
                    MessageBox.Show("Welcome, " +user.getUsername() + "!");                    
                    buttonSearch.Enabled = true; //now that the user is signed in they can search for books
                }
            }
            textBoxPassword.Clear();
            textBoxUsername.Clear();
            if (signedin == false)
                MessageBox.Show("Username or Password is incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void buttonDisplayMostRead_Click(object sender, EventArgs e)
        {
            int n = 0;
            string mostRead = "";
            Book most = new Book();
            foreach (Book book in booklist) //to find book that's been read the most
            {
                if (book.getNumOfBookReaders() == n)
                {
                    mostRead = mostRead + " and " + book.getTitle();
                    most = book;
                }
                if (book.getNumOfBookReaders() > n) //to find book that's been read the most
                {
                    n = book.getNumOfBookReaders();
                    mostRead = book.getTitle();
                    most = book;
                }
               
            }
            textBoxDisplayAdmin.Clear();
            if (n != 0)
                textBoxDisplayAdmin.AppendText(mostRead + " is the most read book, it has been read " + most.getNumOfBookReaders() + " times" );
            else textBoxDisplayAdmin.AppendText("No books have been read yet");
        }

        private void buttonRating_Click(object sender, EventArgs e)
        {
            Book savebook = new Book();
            int n = 0;
            string highest = "";
            foreach (Book book in booklist) //search for the book with the highest rating
            {
                if (book.getRating() == n)
                {
                    highest = highest + " and " + book.getTitle();
                    savebook = book;
                }
                if (book.getRating() > n) 
                {
                    n = book.getRating();
                    highest = book.getTitle();
                    savebook = book;
                }

            }
            textBoxDisplayAdmin.Clear();
            if (n != 0)
                textBoxDisplayAdmin.AppendText(highest + " is the highest rated with a rating of " + savebook.getRating());
            else textBoxDisplayAdmin.AppendText("No books have been rated yet");

        }

        private void buttonSubmitRating_Click(object sender, EventArgs e)
        {
            
                foreach(Book book in booklist)
                {
                    if (book.getTitle() == textBoxSearch.Text && book.getTitle() != null || book.getAuthor() == textBoxSearch.Text && book.getAuthor() != null)
                    {
                        book.setRating(Convert.ToInt32(numericUpDown1.Value));
                        MessageBox.Show("You gave a rating of " + Convert.ToInt32(numericUpDown1.Value) + ". Thank you for rating!", "", MessageBoxButtons.OK);
                    }
                }

            numericUpDown1.Value = 1;
            textBoxSearch.Clear();
        }

        
            
        }

        

        
    }


