using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NotesApp
{
    public class User
    {
        private string username;
        private string email;
        private string password;
        private List<Note> notes;

        public User() { }
        public User(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            this.password = password;
        }
        public User(string username, string email, string password, List<Note> notes)
        {
            this.username = username;
            this.email = email;
            this.password = password;
            this.notes = notes;
        }

        public string Username
        {
            get => username;
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9]+$"))
                    username = value;
                else
                    throw new Exception("Il formato dell'username è errato.");
           }
        }
        public string Email 
        { 
            get => email;
            set
            {
                if(Regex.IsMatch(value, @"^[A-Za-z0-9\.\-_]+@\w+\.[A-Za-z]{2,6}$", RegexOptions.IgnoreCase))
                    email = value;
                else
                    throw new Exception("Il formato dell'email è errato.");
            }
        }
        public string Password 
        { 
            get => password;
            set 
            {
                if (Regex.IsMatch(value, @"^(?=.*?[$€#.@_]).{5,}$"))
                    password = value;
                else
                    throw new Exception("Il formato della password è errato (Almeno 5 caratteri, almeno un carattere speciale).");
            }
        }

        public List<Note> Notes { get => notes; set => notes = value; }
    }
}
