using System;
using TP_MOD6_103022400143;

class Program
{
    static void Main(string[] args)
    {
        // Membuat object
        SayaMusicTrack track1 = new SayaMusicTrack("Hati-Hati di Jalan");

        // Menambah play count
        track1.IncreasePlayCount(10);
        track1.IncreasePlayCount(5);

        // Menampilkan detail
        track1.PrintTrackDetails();
    }
}