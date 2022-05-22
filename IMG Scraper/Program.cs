using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;

namespace Discord_Emoji_Scraper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            start:
            using (WebClient webClient = new WebClient())
            
            try
            {
                if (id < 1000000000000000000)
                {
                    id++;
                    string WordID = "" + id;
                    string disurl = "https://cdn.discordapp.com/emojis/" + WordID + ".png?v=1&size=100";
                    if (WordID.Length < 18)
                    {
                        int diff = 18 - WordID.Length;
                        WordID += new string('0', diff);
                        
                    }
                    HttpWebRequest request = WebRequest.Create(disurl) as HttpWebRequest;
                    request.Method = "HEAD";
                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                    string filePath = @"EmojisPng.txt";
                    string content = disurl;
                    using (StreamWriter outputFile = new StreamWriter(filePath))
                    {
                        outputFile.WriteLine(content);
                            Console.Write(id + " Does Work!");
                            goto start;
                    }

                }
                else if (id > 1000000000000000000)
                {
                    Console.WriteLine("Done");
                    return;
                }

            }
                catch
                {
                    Console.WriteLine(id + " Not Work");
                    goto start;
                }
            
            
        }
        public static long id = 10000000000000000;

    }
}
