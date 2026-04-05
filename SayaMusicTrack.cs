using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MOD6_103022400143
{
    using System;

    class SayaMusicTrack
    {
        // Atribut
        private int id;
        private int playCount;
        private string title;

        // Constructor
        public SayaMusicTrack(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999); // 5 digit random
            this.title = title;
            this.playCount = 0;
        }

        // Method untuk menambah play count
        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        // Method untuk print detail
        public void PrintTrackDetails()
        {
            Console.WriteLine("ID Track   : " + id);
            Console.WriteLine("Title      : " + title);
            Console.WriteLine("Play Count : " + playCount);
            Console.WriteLine("---------------------------");
        }
    }

}
