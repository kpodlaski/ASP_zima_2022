using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace StartApp
{
    class StreamsAndText
    {
        static void WriteToFile()
        {
            StreamWriter sw = new StreamWriter("PantTadeusz.txt");
            sw.Write("Litwo Ojczyzno moja ty jesteś ...");
            sw.Close();
        }

        static void ReadFromFile()
        {
            StreamReader sr=null;
            try {  
                sr = new StreamReader("PantTadeusz.txt");
                Console.WriteLine("Otworzono plik");
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine("Zła ścieżka do pliku");
                Console.WriteLine(e.Message);
                return;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Finally ....");
            }
            while (!sr.EndOfStream)
            {
                Console.WriteLine((char) sr.Read());
                
            }
            sr.Close();
        }

        private static void ReadFomWebPage()
        {
            StreamReader sr = null;
            WebClient wc = new WebClient();
            try
            {
                sr = new StreamReader( wc.OpenRead("http://www.uni.lodz.pl") );
                Console.WriteLine("Otworzono stronę www");
                while (!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            finally
            {
                if (  !(sr is null) )
                {
                    sr.Close();
                }
                Console.WriteLine("Finally ....");
            }
            
            
        }
        static void Main(String[] a)
        {
            //WriteToFile();
            //ReadFromFile();
            ReadFomWebPage();
        }

        
    }

}
