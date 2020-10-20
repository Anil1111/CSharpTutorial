using System;
namespace _04.ClassSeparation
{
    public class Statement
    {

        private int pages;
        private string format;

        public Statement(int pages, string format)
        {
            this.Pages = pages;
            this.Format = format;
        }

        public int Pages
        {
            get { return pages; }
            private set { pages = value; }
        }

        public string Format
        {
            get { return format; }
            private set { format = value; }

        }
    }
}
