using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApp
{
    public class Note
    {
        private string title;
        private string author;
        private List<string> pages;

        public Note(string title, string author, List<string> pages)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        public Note() { }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public List<string> Pages { get => pages; set => pages = value; }
    }
}
