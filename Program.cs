using System;
using TP_MOD6_103022400143;

namespace TP_MOD6_103022400143
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SayaMusicTrack track1 = new SayaMusicTrack("Lagu Santai");

                track1.IncreasePlayCount(5000000);
                track1.PrintTrackDetails();

                track1.IncreasePlayCount(20000000); // kena assert

                for (int i = 0; i < 100; i++)
                {
                    track1.IncreasePlayCount(int.MaxValue);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Terjadi error: " + e.Message);
            }
        }
    }
}