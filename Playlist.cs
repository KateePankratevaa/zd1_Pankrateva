using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2
{
    struct Song
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Filename { get; set; }

        public Song (string Author, string Title, string Filename)
        {
            this.Author = Author;
            this.Title = Title;
            this.Filename = Filename;
        }

        public string GetInfo ()
        {
            return $"Автор: {Author}; Название: {Title}; Текстовый файл: {Title}";
        }


    }
    class PlayList
    {
        private Dictionary<Song, int> songs;


        private List<Song> list;
        private int currentIndex;

        public PlayList ()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public Song CurrentSong ()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }

        public void CreateSong (string name, string autor, string filename, int count)
        {
            songs.Add(new Song(name, autor, filename), count);
        }

        public void WriteAllSongs (ListBox listbox)
        {
            foreach (var song in songs)
            {
                listbox.Items.Add(song.Key.GetInfo() + $"; Количество воспроизведений: {songs.Value}");
            }
        }
    }



}
