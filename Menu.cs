using System;
using System.Collections.Generic;
namespace _321pa1
{
    public class Menu
    {

        public List<Songs> playlist;

        public bool menu()
        {
            
            Console.WriteLine("What would you like to do");
            Console.WriteLine(" ");
            Console.WriteLine("[1] Show all available songs");
            Console.WriteLine("[2] Add a song");
            Console.WriteLine("[3] Delete a song");
            Console.WriteLine("[4] Exit");

            switch(int.Parse(Console.ReadLine()))
            {
                case 1:
               
                ShowAllSongs.WriteSongsToConsole(playlist);
                return false;

                case 2: 
                SongUtil songAdd = new SongUtil();
                songAdd.addSong(playlist);
                return false;

                case 3:
                SongUtil deleteSong = new SongUtil();
                deleteSong.deleteSong(playlist);
                return false;

                case 4:

                return true;

                default:

                return false;
            }
        }
    }
}