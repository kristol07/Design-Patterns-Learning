using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternLearning.DecoratorPattern
{
    public abstract class LibraryItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get
            {
                return _numCopies;
            }

            set
            {
                _numCopies = value;
            }
        }

        public abstract void Display();
    }

    public class Book : LibraryItem
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ---- ");
            Console.WriteLine(" Author {0}", _author);
            Console.WriteLine(" Title {0}", _title);
            Console.WriteLine(" #Copies {0}", NumCopies);
        }
    }

    public abstract class Decorator : LibraryItem
    {
        protected LibraryItem libraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            this.libraryItem = libraryItem;
        }

        public override void Display()
        {
            libraryItem.Display();
        }
    }

    public class Borrowable : Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem): base(libraryItem) { }

        public void BorrowItem(string borrower)
        {
            borrowers.Add(borrower);
            libraryItem.NumCopies -= 1;
        }

        public void ReturnItem(string borrower)
        {
            borrowers.Remove(borrower);
            libraryItem.NumCopies += 1;
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in borrowers)
            {
                Console.WriteLine(" borrower: " + borrower);
            }
        }
    }


}
