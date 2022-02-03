using System.IO;
using System.Collections.Generic;
using System;

namespace _321pa1
{
    public class ShowAllSongs
    {
        
        public static List<Songs> GetSongs()
        {
            List<Songs> mySongsList = new List<Songs>();

            StreamReader inFile = new StreamReader("songs.txt");
            string line  = inFile.ReadLine();

            while(line != null)
            {
                string[] temp = line.Split("#");
                mySongsList.Add(new Songs(){ID = int.Parse(temp[0]), Title = temp[1], Date = DateTime.Parse(temp[2])});
                line = inFile.ReadLine();
            }

            


            inFile.Close();
            return mySongsList;
        }


        public static void WriteSongsToConsole(List<Songs> mySongsList)
        {
            foreach(Songs song in mySongsList)
            {
                Console.WriteLine(song.ID + song.Title + song.Date);
            }
        }

           
    }
}