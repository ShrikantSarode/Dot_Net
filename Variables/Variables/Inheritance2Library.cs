using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Inheritance2Library
    {

        public void Librarys()
        {
            Console.WriteLine("Library");
        }
    }
    class Book : Inheritance2Library
    {

        public void Books()
        {
            Console.WriteLine("Books");
        }

    }
    class BookCategory : Book
    {

        public void Category()
        {
            Console.WriteLine("Category");
        }

    }
    class LoveStory : BookCategory
    {

        public void LoveStorys()
        {
            Console.WriteLine("Love Story");
        }

        public void Documentary()
        {
            Console.WriteLine("Documentary");
        }

    }
    class Customer
    {
        static void Main(string[] args)
        {
            LoveStory loveStory = new LoveStory();
            loveStory.Librarys();
            loveStory.Books();
            loveStory.Category();
            loveStory.LoveStorys();
        }
    }
}
