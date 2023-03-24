using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace malek_barakeh
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to my game");
            char[] lines = { '_' ,'_' ,'_' ,'_' };
            for(int i =0; i < lines.Length; i++)
            {
                Console.Write(lines[i]+ " ");
                

                
            }
            Console.WriteLine("");
            string word = getTodayWord();
            int heart = getTodayWord().Length;

            while (heart > 0)
            {
                char c = asKUser();
                int r = checKLetter(getTodayWord(), c,lines);
                if (r == -1)
                {
                    heart--;
                    Console.WriteLine("you have " + heart + " hearts left");

                }
                else
                {
                    lines[r]= c;
                }
               
                for (int i = 0; i < lines.Length; i++)
                {
                    Console.Write(lines[i]+" "); 
                }

               
                 if(checKWin(word,lines) ==1)
                {
                    Console.WriteLine("You win");
                    return;
                }
                

                
            }
            Console.WriteLine("you lose");
        }
         
        public static char asKUser()
        {
            Console.WriteLine("please enter a char: ");
            char ch = Console.ReadLine()[0];
            return ch;
        } 

         public static string getTodayWord()
        {
            string[] words = { "eggs", "home", "ford", "loop" };
            Random rnd = new Random();
            int num = rnd.Next(1, words.Length);
            return words[num];
        }     
        public static int checKLetter(string getTodayWord, char ch, char[] lines)
        {
           for(int i =0; i<getTodayWord.Length; i++)
            {
                if (getTodayWord[i]== ch && lines[i] != ch) {
                    return i;
                }
            }
           return -1;
        }
        public static int checKWin(string getTodayWord, char[] lines)
        {

            for (int i = 0; i < getTodayWord.Length;)
            {
                if (lines[i] != getTodayWord[i])
                {
                    return -1;
                }
            }
            return 1;
        }

    }
   
}
