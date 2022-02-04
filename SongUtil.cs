using System;
using System.IO;
using System.Collections.Generic;
namespace _321pa1
{
    public class SongUtil
    {
        

        
        public void addSong(List<Songs> mySongsList)
        {
            Songs currentSong = new Songs();

            int count = mySongsList.Count;
            currentSong.ID = count;
            
        

            Console.WriteLine("What is the song title?");
            currentSong.Title = Console.ReadLine();

            
            currentSong.Date = DateTime.Now;

            mySongsList.Add(currentSong);
            mySongsList.Reverse();



            StreamWriter outFile = new StreamWriter("songs.txt");
            foreach(Songs song in mySongsList)
            {
                outFile.WriteLine(song.ID + "#" + song.Title + "#" + song.Date);
            }
            

            outFile.Close();
        }

          public static void WriteSongsToConsole(List<Songs> mySongsList)
        {
            foreach(Songs song in mySongsList)
            {
                Console.WriteLine(song.ID  +  song.Title  +  song.Date);
            }
        }


        public void deleteSong(List<Songs> mySongsList)
        {
            int answer;
            WriteSongsToConsole(mySongsList);
            Console.WriteLine(" ");
            Console.WriteLine("Which song would you like to delete?(Enter in the ID)");

            
            answer = int.Parse(Console.ReadLine());
            mySongsList.RemoveAt(answer);

              StreamWriter outFile = new StreamWriter("songs.txt");
            foreach(Songs song in mySongsList)
            {
                outFile.WriteLine(song.ID + "#" + song.Title + "#" + song.Date);
            }
            

            outFile.Close();

        }



      
    }
}