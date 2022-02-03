using System;
using System.IO;
using System.Collections.Generic;

namespace _321pa1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List <Songs> orgplaylist = ShowAllSongs.GetSongs();
            
            Songs newSong = new Songs();
           



            bool endProgram;
            do
            {
                Menu firstMenu = new Menu(){playlist = orgplaylist};
                endProgram = firstMenu.menu();

            }while (endProgram == false);
        }
    }
}
