using System;
using System.Collections.Generic;
using System.Text;

namespace Tumakov
{
    class Song
    {
        string Name;
        string Author;
        Song Prev;
        public Song()
        {

        }
        public Song(string name, string author)
        {
            Name = name;
            Author = author;
            Prev = null;
        }
        public Song(string name, string author, Song prev)
        {
            Name = name;
            Author = author;
            Prev = prev;
        }
        public void GetName(string name)
        {
            Name = name;
        }
        public void GetAuthor(string author)
        {
            Author = author;
        }
        public void GetPrev(Song song)
        {
            Prev = song;
        }
        public void Comparison(Song song1, Song song2)
        {

        }
        public string Title()
        {
            return $"{Name} {Author}";
        }

    }
}
