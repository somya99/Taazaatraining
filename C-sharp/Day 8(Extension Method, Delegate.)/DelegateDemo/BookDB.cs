using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace DelegateDemo
{
    public delegate void ProcessBookCallbackDelegate(Book book);
    public class BookDB
    {
        ArrayList list = new ArrayList();
        public void AddBook(String title, string author, decimal price, bool paperBack)
        {
            list.Add(new Book
            {
                Title = title,
                Author = author,
                Price = price,
                Paperback = paperBack
            });
        }
        public void ProcessPaperbackBooks(ProcessBookCallbackDelegate processBook)
        {
            foreach(Book b in list)
            {
                if (b.Paperback){
                    processBook(b);
                }
            }
        }
    }
}
